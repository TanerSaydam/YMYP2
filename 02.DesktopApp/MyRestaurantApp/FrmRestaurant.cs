using MyRestaurantApp.Models;

namespace MyRestaurantApp;

public partial class FrmRestaurant : Form
{
    int tableCount = 30;
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
    }

    private void CreateTables()
    {
        int x = 0;
        int y = 12;
        int count = 0;


        for (int i = 0; i < tableCount; i++)
        {
            var table = new Table();
            table.Number = i + 1;
            table.IsAvailable = true;
            table.IsPayment = false;
            table.TotalAmount = 0;
            table.PaidAmount = 0;
            tables.Add(table);

            var btn = new Button();

            x = 275 * count; //ilk kayýt indexe göre 0 dan baþlar

            btn.Size = new Size(269, 175);
            btn.BackColor = emptyBackgrounColor;
            btn.ForeColor = foreColor;
            btn.Visible = true;
            btn.Name = "btnTable" + (i + 1);
            btn.Text = "Masa " + (i + 1);
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

        string tableName = "btnTable" + tableNumber; //btnTable1
        this.Controls.Find(tableName, true)[0].BackColor = table.IsAvailable ? emptyBackgrounColor : fillBackgroundColor;
    }
}
