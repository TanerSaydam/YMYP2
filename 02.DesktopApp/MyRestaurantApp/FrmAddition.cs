using MyRestaurantApp.Models;

namespace MyRestaurantApp;
public partial class FrmAddition : Form
{
    string _tableName = string.Empty;
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
        
    }

    private void lstMenu_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        string text = (sender as ListBox).Text;
        lstAddition.Items.Add(text);
    }

    private void btnTableIsAvailable_Click(object sender, EventArgs e)
    {
        _frmRestaurant.ChangeTableAvailability(tableNumber);
        changeBtnTableIsAvailableProperties();
    }

    private void changeBtnTableIsAvailableProperties()
    {
        table = _frmRestaurant.tables.Where(p => p.Number == tableNumber).FirstOrDefault();
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
}
