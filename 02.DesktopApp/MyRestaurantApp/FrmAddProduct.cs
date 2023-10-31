using MyRestaurantApp.Context;
using MyRestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRestaurantApp;

public partial class FrmAddProduct : Form
{
    private List<ProductVariant> productVariants = new();
    private Product product = new();
    private ApplicationDbContext context = new();

    public FrmAddProduct()
    {
        InitializeComponent();
    }

    private void btnVariantAdd_Click(object sender, EventArgs e)
    {
        if (txtVariantName.Text.Length < 3)
        {
            MessageBox.Show("Geçerli bir varyant adı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        decimal price = 0;
        var result = decimal.TryParse(txtVariantPrice.Text, out price);
        if (!result)
        {
            MessageBox.Show("Geçerli bir rakam giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (price < 0)
        {
            MessageBox.Show("Varyant fiyatı 0 dan düşük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (productVariants.Any(p => p.Name.ToLower() == txtVariantName.Text.ToLower()))
        {
            MessageBox.Show("Bu varyant daha önce eklenmiş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ProductVariant variant = new()
        {
            Name = txtVariantName.Text,
            Price = price
        };
        productVariants.Add(variant);

        dG1.Rows.Add();
        dG1.Rows[dG1.Rows.Count - 1].Cells[0].Value = txtVariantName.Text;
        dG1.Rows[dG1.Rows.Count - 1].Cells[1].Value = price;

        txtVariantName.Text = "";
        txtVariantPrice.Text = "0";
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (txtName.Text.Length < 3)
        {
            MessageBox.Show("Geçerli bir ürün adı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        decimal price = 0;
        var result = decimal.TryParse(txtPrice.Text, out price);
        if (!result)
        {
            MessageBox.Show("Geçerli bir rakam giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (price < 0)
        {
            MessageBox.Show("Ürün fiyatı 0 dan düşük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (context.Products.Any(p => p.Name.ToLower() == txtName.Text.ToLower()))
        {
            MessageBox.Show("Bu ürün daha önce eklenmiş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        product = new()
        {
            Name = txtName.Text,
            Price = price,
            ProductVariants = productVariants
        };
        context.Add(product);
        context.SaveChanges();

        txtName.Text = "";
        txtPrice.Text = "0";
        txtVariantName.Text = "";
        txtVariantPrice.Text = "0";
        product = new();
        productVariants = new();

        MessageBox.Show("Ürün başarıyla tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}