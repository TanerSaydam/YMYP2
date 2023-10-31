using Azure.Core;
using Iyzipay.Model;
using MyRestaurantApp.DTOs;

namespace MyRestaurantApp;

public partial class FrmPayment : Form
{
    private readonly FrmAddition _frmAdition;

    public FrmPayment(string total, FrmAddition frmAddition)
    {
        InitializeComponent();
        lbTotal.Text = total;
        _frmAdition = frmAddition;
        gbCC.Visible = true;
        gbCC.Enabled = false;
        //this.Size = new System.Drawing.Size(394, 290);
        //this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 245);
    }

    private void cbCC_CheckedChanged(object sender, EventArgs e)
    {
        if (cbCC.Checked)
        {
            gbCC.Enabled = true;
        }
        else
        {
            gbCC.Enabled = false;
        }
        //if (cbCC.Checked)
        //{
        //    gbCC.Visible = true;
        //    btnMakeThePayment.Location = new System.Drawing.Point(13, 535);
        //    gbCC.Location = new System.Drawing.Point(9, 197);
        //    Size = new System.Drawing.Size(396, 639);
        //    //Location = new System.Drawing.Point(Location.X, Location.Y - 245);
        //}
        //else
        //{
        //    gbCC.Visible = false;
        //    btnMakeThePayment.Location = new System.Drawing.Point(9, 197);
        //    Size = new System.Drawing.Size(394, 290);
        //    //Location = new System.Drawing.Point(Location.X, Location.Y + 245);
        //}
    }

    private void btnMakeThePayment_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtCash.Text)) txtCash.Text = "0";
        if (string.IsNullOrEmpty(txtCC.Text)) txtCC.Text = "0";

        PaymentCard paymentCard = new()
        {
            CardHolderName = txtCCOwner.Text,
            CardNumber = txtCCNumber1.Text + txtCCNumber2.Text + txtCCNumber3.Text + txtCCNumber4.Text,
            Cvc = txtCVC.Text,
            ExpireMonth = txtExpireMounth.Text,
            ExpireYear = txtExpireYear.Text,
            RegisterCard = 0
        };

        Buyer buyer = new Buyer();
        buyer.Id = "BY789";
        buyer.Name = "John";
        buyer.Surname = "Doe";
        buyer.GsmNumber = "+905350000000";
        buyer.Email = "email@email.com";
        buyer.IdentityNumber = "74300864791";
        buyer.LastLoginDate = "2015-10-05 12:43:35";
        buyer.RegistrationDate = "2013-04-21 15:12:09";
        buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        buyer.Ip = "85.34.78.112";
        buyer.City = "Istanbul";
        buyer.Country = "Turkey";
        buyer.ZipCode = "34732";

        Address shippingAddress = new Address();
        shippingAddress.ContactName = "Jane Doe";
        shippingAddress.City = "Istanbul";
        shippingAddress.Country = "Turkey";
        shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        shippingAddress.ZipCode = "34742";

        Address billingAddress = new Address();
        billingAddress.ContactName = "Jane Doe";
        billingAddress.City = "Istanbul";
        billingAddress.Country = "Turkey";
        billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
        billingAddress.ZipCode = "34742";

        IyzipayRequest iyzipayRequest = new(
            Cash: decimal.Parse(txtCash.Text),
            CreditCartAmount: decimal.Parse(txtCC.Text),
            PaymentCard: paymentCard,
            Buyer: buyer,
            ShippingAddress: shippingAddress,
            BillingAddress: billingAddress);

        var result = _frmAdition.PayTableAmount(iyzipayRequest);
        if (result) Close();
    }

    private void FrmPayment_Load(object sender, EventArgs e)
    {
    }
}