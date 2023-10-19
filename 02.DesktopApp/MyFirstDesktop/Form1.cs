namespace MyFirstDesktop;

public partial class Form1 : Form
{
    public int index = 0;
    public Form1()
    {
        InitializeComponent();

        btnUpdate.Visible = false;
        btnCancel.Visible = false;
    }


    private void button1_Click(object sender, EventArgs e)
    {
        lstTodos.Items.Add(txtWork.Text);
        txtWork.Text = "";
    }

    private void lstTodos_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (MessageBox.Show("Silmek istiyor musunuz?", "Sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            lstTodos.Items.Remove(lstTodos.SelectedItem);
            txtWork.Text = "";
        }

    }

    private void lstTodos_MouseClick(object sender, MouseEventArgs e)
    {
        txtWork.Text = lstTodos.SelectedItem.ToString();
        index = lstTodos.SelectedIndex;
        btnUpdate.Visible = true;
        btnCancel.Visible = true;
        btnSave.Visible = false;
        lstTodos.Height = 184;
        lstTodos.Location = new Point(12, 182);
    }

    private void button2_Click(object sender, EventArgs e)
    {
        lstTodos.Items[index] = txtWork.Text;
        txtWork.Text = "";
        btnUpdate.Visible = false;
        btnCancel.Visible = false;
        btnSave.Visible = true;
        lstTodos.Height = 244;
        lstTodos.Location = new Point(12, 122);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        btnCancel.Visible = false;
        btnUpdate.Visible = false;
        btnSave.Visible = true;
        txtWork.Text = "";
        lstTodos.Height = 244;
        lstTodos.Location = new Point(12, 122);
    }
}
