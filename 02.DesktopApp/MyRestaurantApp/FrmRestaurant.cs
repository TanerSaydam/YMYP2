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


        var formAddition = new FrmAddition(tableName, this); //instance olu�turma // �rnek olu�turma //newleme 
        formAddition.Show(); //formu g�sterme
        this.Enabled = false; //formu kapatana kadar di�er formu kapatma
    }

    private void CreateTables()
    {
        ApplicationDbContext context = new(); //istance t�rettim yani �rne�ini ald�m
        tables = context.Tables.ToList(); //tablo listesini ald�m ve de�i�kenime set ettim

        int x = 0;
        int y = 12;
        int count = 0;


        foreach (var table in tables)
        {
            var btn = new Button();

            x = 275 * count; //ilk kay�t indexe g�re 0 dan ba�lar

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
