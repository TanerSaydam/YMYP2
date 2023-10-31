using MyRestaurantApp.Context;
using MyRestaurantApp.Models;

namespace MyRestaurantApp;

public partial class FrmRestaurant : Form
{
    public List<Table> tables = new();
    private Color emptyBackgrounColor = Color.DarkSeaGreen;
    private Color fillBackgroundColor = Color.IndianRed;
    private Color foreColor = Color.White;

    public FrmRestaurant()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        CreateTables();
    }

    private void ShowAdditionForm(object sender, EventArgs e)
    {
        string tableName = (sender as Button).Text;

        var formAddition = new FrmAddition(tableName, this); //instance oluþturma // örnek oluþturma //newleme
        formAddition.Show(); //formu gösterme
        this.Enabled = false; //formu kapatana kadar diðer formu kapatma
    }

    private void CreateTables()
    {
        ApplicationDbContext context = new(); //istance türettim yani örneðini aldým
        tables = context.Tables.ToList(); //tablo listesini aldým ve deðiþkenime set ettim

        int x = 0;
        int y = 12;
        int count = 0;

        foreach (var table in tables)
        {
            var btn = new Button();

            x = 275 * count; //ilk kayýt indexe göre 0 dan baþlar

            btn.Size = new Size(269, 175);
            btn.BackColor = table.IsAvailable ? emptyBackgrounColor : fillBackgroundColor;
            btn.ForeColor = foreColor;
            btn.Visible = true;
            btn.Name = "btnTable" + table.Number;
            btn.Text = "Masa " + table.Number;
            btn.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            btn.Click += ShowAdditionForm;

            if (x < 1920)
            {
                btn.Location = new Point(x, y);
            }
            else
            {
                x = 0;
                count = 0;
                y += 189;

                btn.Location = new Point(x, y);
            }

            this.Controls.Add(btn);

            count++;
        }
    }

    public void ChangeTableAvailability(int tableNumber)
    {
        var table = tables.Where(p => p.Number == tableNumber).FirstOrDefault();
        table.IsAvailable = !table.IsAvailable;

        ApplicationDbContext context = new();
        context.Update(table);
        context.SaveChanges();

        string tableName = "btnTable" + tableNumber; //btnTable1
        this.Controls.Find(tableName, true)[0].BackColor = table.IsAvailable ? emptyBackgrounColor : fillBackgroundColor;
    }

    private void seedDataEkleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ApplicationDbContext context = new();

        if (!context.Products.Any())
        {
            List<Product> products = new();
            products.Add(new()
            {
                Name = "Ýçecek",
                Price = 40,
                ProductVariants = new()
            {
                new ProductVariant() {Name = "Kola", Price=40},
                new ProductVariant() {Name = "Fanta", Price=40},
                new ProductVariant() {Name = "Ayran", Price=40}
            }
            });
            products.Add(new()
            {
                Name = "Ýskender",
                Price = 240,
                ProductVariants = new()
            {
               new ProductVariant() {Name = "Tek Ýskender", Price=240},
               new ProductVariant() {Name = "1,5 Ýskender", Price=440},
               new ProductVariant() {Name = "Double Ýskender", Price=640}
            }
            });
            products.Add(new()
            {
                Name = "Çorba",
                Price = 120,
                ProductVariants = new()
            {
               new ProductVariant() {Name = "Mercimek", Price=120},
               new ProductVariant() {Name = "Paça", Price=140}
            }
            });
            products.Add(new() { Name = "Ýçli Köfte", Price = 120 });
            products.Add(new() { Name = "Kayseri Çývýklýsý", Price = 420 });

            context.AddRange(products);
            context.SaveChanges();
        }
    }

    private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmAddProduct frmAddProduct = new();
        frmAddProduct.ShowDialog();
    }

    private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmReport frmReport = new();
        frmReport.ShowDialog();
    }
}