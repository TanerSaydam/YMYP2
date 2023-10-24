using MyRestaurantApp.Models;

namespace MyRestaurantApp;
public partial class FrmProductVariants : Form
{
    Product _product = new();
    FrmAddition _frmAddition;
    public FrmProductVariants(Product product, FrmAddition frm)
    {
        InitializeComponent();

        _product = product;
        _frmAddition = frm;

        foreach (var productVariant in product.ProductVariants)
        {
            lstMenu.Items.Add(productVariant.Name);
        }
    }

    private void SelectProduct(string name)
    {
        ProductVariant productVariant = _product.ProductVariants.Where(p => p.Name == name).FirstOrDefault();
        _frmAddition.AddAddition(_product.Id, productVariant);
        this.Close();
    }

    private void lstMenu_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        string text = (sender as ListBox).Text;
        SelectProduct(text);
    }

    private void FrmProductVariants_FormClosed(object sender, FormClosedEventArgs e)
    {
        _frmAddition.Enabled = true;
    }
}
