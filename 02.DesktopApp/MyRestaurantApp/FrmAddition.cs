using Azure.Core;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.EntityFrameworkCore;
using MyRestaurantApp.Context;
using MyRestaurantApp.DTOs;
using MyRestaurantApp.Models;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace MyRestaurantApp;

public partial class FrmAddition : Form
{
    private ApplicationDbContext context = new();

    //tekrar yaz-sil-yaz
    private string _tableName = string.Empty;

    private List<Product> products = new();
    private List<Addition> additions = new();
    private int tableNumber = 0;
    private Table table = new();
    private FrmRestaurant _frmRestaurant = new();

    public FrmAddition(string tableName, FrmRestaurant restaurantForm)
    {
        InitializeComponent();
        _tableName = tableName;
        _frmRestaurant = restaurantForm;
        lbTableName.Text = tableName;
        tableNumber = int.Parse(_tableName.Replace("Masa ", ""));
        changeBtnTableIsAvailableProperties();
        table = _frmRestaurant.tables.Where(p => p.Number == tableNumber).FirstOrDefault();

        btnTableIsAvailable.BackColor = table.IsAvailable ? Color.DarkSeaGreen : Color.IndianRed;
        btnTableIsAvailable.Text = table.IsAvailable ? "Masa Müsait" : "Dolu";

        ApplicationDbContext context = new();

        additions =
            context.Additions
                .Where(p => p.TableId == table.Id)
                .Include(p => p.Product)
                .Include(p => p.ProductVariant)
                .ToList();

        foreach (var addition in additions)
        {
            if (addition.ProductVariantId != null)
            {
                lstAddition.Items.Add(addition.ProductVariant.Name);
            }
            else
            {
                lstAddition.Items.Add(addition.Product.Name);
            }
        }
    }

    private void FrmAddition_Load(object sender, EventArgs e)
    {
        ApplicationDbContext context = new();
        products = context.Products.Include(p => p.ProductVariants).ToList();
        foreach (var product in products)
        {
            lstMenu.Items.Add(product.Name);
        }

        lbTotal.Text = table.TotalAmount.ToString("C2");
    }

    private void lstMenu_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        string text = (sender as ListBox).Text;
        Product product = products.Where(p => p.Name == text).FirstOrDefault();
        if (product is null)
        {
            MessageBox.Show("Ürün bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (product.ProductVariants.Count > 0)
        {
            FrmProductVariants frmProductVariants = new(product, this);
            frmProductVariants.Show();
            this.Enabled = false;
        }
        else
        {
            lstAddition.Items.Add(text);

            table.TotalAmount += product.Price;

            if (table.IsAvailable) // == true
            {
                _frmRestaurant.ChangeTableAvailability(tableNumber);
                changeBtnTableIsAvailableProperties();
            }

            ApplicationDbContext context = new();

            Addition addition = new()
            {
                AdditionDate = DateTime.Now,
                IsPaid = false,
                Price = product.Price,
                ProductId = product.Id,
                TableId = table.Id,
                ProductVariantId = null
            };

            additions.Add(addition);

            context.Additions.Add(addition);
            context.Update(table);

            context.SaveChanges();

            lbTotal.Text = table.TotalAmount.ToString("C2");
        }
    }

    public void AddAddition(int productId, ProductVariant productVariant)
    {
        ApplicationDbContext context = new();

        lstAddition.Items.Add(productVariant.Name);

        table.TotalAmount += productVariant.Price;

        if (table.IsAvailable) // == true
        {
            _frmRestaurant.ChangeTableAvailability(tableNumber);
            changeBtnTableIsAvailableProperties();
        }
        context.Tables.Update(table);

        Addition addition = new()
        {
            AdditionDate = DateTime.Now,
            IsPaid = false,
            Price = productVariant.Price,
            ProductId = productId,
            TableId = table.Id,
            ProductVariantId = productVariant.Id
        };

        additions.Add(addition);
        context.Additions.Add(addition);

        context.SaveChanges();

        lbTotal.Text = table.TotalAmount.ToString("C2");
    }

    private void btnTableIsAvailable_Click(object sender, EventArgs e)
    {
        if (table.TotalAmount > 0 && !table.IsAvailable)
        {
            MessageBox.Show(
                "Masanın ödenmemiş hesabı var! Hesabı ödemeden masayı müsaite çeviremezsiniz!",
                "Hata!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        _frmRestaurant.ChangeTableAvailability(tableNumber);
        changeBtnTableIsAvailableProperties();
    }

    private void changeBtnTableIsAvailableProperties()
    {
        if (table is null)
        {
            MessageBox.Show("Masa bilgisi bulunamadı", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        if (table.IsAvailable)
        {
            btnTableIsAvailable.BackColor = Color.DarkSeaGreen;
            btnTableIsAvailable.ForeColor = Color.White;
            btnTableIsAvailable.Text = "Müsait";
        }
        else
        {
            btnTableIsAvailable.BackColor = Color.IndianRed;
            btnTableIsAvailable.ForeColor = Color.White;
            btnTableIsAvailable.Text = "Dolu";
        }
    }

    public bool PayTableAmount(IyzipayRequest iyzipayRequest)
    {
        if (iyzipayRequest.Cash + iyzipayRequest.CreditCartAmount <= 0)
        {
            MessageBox.Show("Ödeme tutarı 0 olamaz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (iyzipayRequest.Cash + iyzipayRequest.CreditCartAmount != (table.TotalAmount - table.PaidAmount))
        {
            MessageBox.Show("Ödeme tutarı ödenecek tutardan farklı olamaz!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (table.IsAvailable == false && table.TotalAmount > table.PaidAmount)
        {
            if (MessageBox.Show(
                   "Masanın hesabını kapatmak istiyor musunuz?",
                   "Hesabı Öde",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (iyzipayRequest.CreditCartAmount > 0)
                {
                    try
                    {
                        List<BasketItem> basketItems = new();
                        decimal ccAmount = iyzipayRequest.CreditCartAmount;
                        int index = -1;
                        while (ccAmount > 0)
                        {
                            index++;
                            var data = this.additions[index];

                            string productName = "";
                            if (data.ProductVariantId is not null)
                            {
                                productName =
                                    context.ProductVariants
                                    .Where(p => p.Id == data.ProductVariantId)
                                    .AsNoTracking()
                                    .FirstOrDefault()
                                    .Name;
                            }
                            else
                            {
                                productName = context.Products
                                    .Where(p => p.Id == data.ProductId)
                                    .AsNoTracking()
                                    .FirstOrDefault()
                                    .Name;
                            }

                            BasketItem basketItem = new BasketItem();
                            basketItem.Id = Guid.NewGuid().ToString();
                            basketItem.Name = productName;
                            basketItem.Category1 = "Category1";
                            basketItem.Category2 = "Category2";
                            basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                            basketItem.Price = (data.Price > ccAmount ? ccAmount : data.Price).ToString().Replace(",", ".");

                            basketItems.Add(basketItem);

                            ccAmount -= data.Price;
                        }

                        var result = PayWithIyzico(iyzipayRequest, basketItems);
                        if (!result)
                            return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                table.TotalAmount = 0;
                table.PaidAmount = 0;

                List<PaymentHistory> paymentHistories = new();
                foreach (var addition in additions)
                {
                    PaymentHistory paymentHistory = new()
                    {
                        TableId = table.Id,
                        PaymentDate = DateTime.Now,
                        Price = addition.Price,
                        PaymentType = iyzipayRequest.Cash > 0 ? PaymentType.Cash : PaymentType.CreditCart,
                        ProductId = addition.ProductId,
                        ProductVariantId = addition.ProductVariantId
                    };
                    paymentHistories.Add(paymentHistory);
                }

                context.AddRange(paymentHistories);
                context.RemoveRange(additions);
                context.Update(table);

                context.SaveChanges();

                additions = new();

                lstAddition.Items.Clear();

                _frmRestaurant.ChangeTableAvailability(tableNumber);
                changeBtnTableIsAvailableProperties();

                lbTotal.Text = 0.ToString("C2");

                return true;
            }
        }

        return false;
    }

    private bool PayWithIyzico(IyzipayRequest iyzipayRequest,
    List<BasketItem> basketItems)
    {
        //iyzico ile gerçekten çalışmaya başarsanız bu kısmı değiştirmeniz yeterli.
        var options = new Options()
        {
            ApiKey = "sandbox-uKTe5VmnUQMQVpyGRCbMqZQOjTCyb0yM",
            SecretKey = "sandbox-WyungnQ9HfKf0SCgY66gqkL5J5PCvhFb",
            BaseUrl = "https://sandbox-api.iyzipay.com"
        };

        CreatePaymentRequest request = new CreatePaymentRequest();
        request.Locale = Locale.TR.ToString();
        request.ConversationId = Guid.NewGuid().ToString();
        request.Price = iyzipayRequest.CreditCartAmount.ToString(); //ödeme tutarımız
        request.PaidPrice = iyzipayRequest.CreditCartAmount.ToString(); //kullanıcın ödeyeceğiz komisyonlu
        request.Currency = Currency.TRY.ToString();
        request.Installment = 1;
        request.BasketId = Guid.NewGuid().ToString(); //sipariş numarası
        request.PaymentChannel = PaymentChannel.WEB.ToString();
        request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

        request.PaymentCard = iyzipayRequest.PaymentCard;
        request.Buyer = iyzipayRequest.Buyer;
        request.ShippingAddress = iyzipayRequest.ShippingAddress;
        request.BillingAddress = iyzipayRequest.BillingAddress;
        request.BasketItems = basketItems;

        Payment payment = Payment.Create(request, options); //ödeme işlemini gerçekleştir

        if (payment.Status != "success")
        {
            MessageBox.Show(payment.ErrorMessage, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return payment.Status == "success";
    }

    private void FrmAddition_FormClosed(object sender, FormClosedEventArgs e)
    {
        _frmRestaurant.Enabled = true;
    }

    private void RemoveProductInAddition(string name)
    {
        Product product =
            products
                .Where(p =>
                    p.Name == name ||
                    p.ProductVariants.Any(p => p.Name == name)).FirstOrDefault();
        if (product is null)
        {
            return;
        }

        if (MessageBox.Show($"{name}'i adisyondan kaldırmak istiyor musunuz?", "", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Addition addition = additions.Where(p => p.ProductId == product.Id).FirstOrDefault();
            additions.Remove(addition);

            table.TotalAmount -= addition.Price;

            ApplicationDbContext context = new();
            context.Remove(addition);
            context.Update(table);

            context.SaveChanges();

            lbTotal.Text = table.TotalAmount.ToString("C2");

            lstAddition.Items.Remove(name);
        }
    }

    private void lstAddition_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        string text = (sender as ListBox).Text;
        RemoveProductInAddition(text);
    }

    private void lbTotal_Click(object sender, EventArgs e)
    {
        FrmPayment frmPayment = new(lbTotal.Text, this);
        frmPayment.ShowDialog();
    }
}