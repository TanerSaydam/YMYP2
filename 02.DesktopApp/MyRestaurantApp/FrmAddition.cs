using Microsoft.EntityFrameworkCore;
using MyRestaurantApp.Context;
using MyRestaurantApp.Models;
using static System.Net.Mime.MediaTypeNames;

namespace MyRestaurantApp;
public partial class FrmAddition : Form
{
    //tekrar yaz-sil-yaz
    string _tableName = string.Empty;
    List<Product> products = new();
    List<Addition> additions = new();
    int tableNumber = 0;
    Table table = new();
    FrmRestaurant _frmRestaurant = new();
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
                .Include(p=> p.ProductVariant)
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
                TableId = table.Id
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

    private void PayTableAmount()
    {
        if (table.IsAvailable == false && table.TotalAmount > table.PaidAmount)
        {
            if (MessageBox.Show(
                    "Masanın hesabını kapatmak istiyor musunuz?",
                    "Hesabı Öde",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ApplicationDbContext context = new();
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
                        ProductId = addition.ProductId,
                        ProductVariantId = addition.ProductVariantId
                    };
                    paymentHistories.Add(paymentHistory);
                }

                context.AddRange(paymentHistories);
                context.RemoveRange(additions);
                context.Update(table);

                context.SaveChanges();

                lstAddition.Items.Clear();

                _frmRestaurant.ChangeTableAvailability(tableNumber);
                changeBtnTableIsAvailableProperties();

                lbTotal.Text = 0.ToString("C2");
            }
        }
    }

    private void lbTotal_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        PayTableAmount();
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
                    p.ProductVariants.Any(p=> p.Name == name)).FirstOrDefault();
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
}
