using MyRestaurantApp.Context;
using MyRestaurantApp.Models;

namespace MyRestaurantApp;

public partial class FrmRestaurant : Form
{
    public List<Table> tables = new();
    Color emptyBackgrounColor = Color.DarkSeaGreen;
    Color fillBackgroundColor = Color.IndianRed;
    Color foreColor = Color.White;

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
}
