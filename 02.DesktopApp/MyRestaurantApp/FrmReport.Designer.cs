namespace MyRestaurantApp;

partial class FrmReport
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        gB1 = new GroupBox();
        dG1 = new DataGridView();
        ProductName = new DataGridViewTextBoxColumn();
        SalesQuantity = new DataGridViewTextBoxColumn();
        ProductAmount = new DataGridViewTextBoxColumn();
        lbCashRevenue = new Label();
        lbCreditCartRevenue = new Label();
        lblRevenue = new Label();
        btnReport = new Button();
        dPEnd = new DateTimePicker();
        dPStart = new DateTimePicker();
        contextMenuStrip1 = new ContextMenuStrip(components);
        btnExportExcel = new Button();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        gB1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dG1).BeginInit();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Location = new Point(12, 12);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(1299, 634);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(gB1);
        tabPage1.Controls.Add(btnReport);
        tabPage1.Controls.Add(dPEnd);
        tabPage1.Controls.Add(dPStart);
        tabPage1.Location = new Point(4, 40);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1291, 590);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Tarih Bazlı Ciro Raporu";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // gB1
        // 
        gB1.Controls.Add(btnExportExcel);
        gB1.Controls.Add(dG1);
        gB1.Controls.Add(lbCashRevenue);
        gB1.Controls.Add(lbCreditCartRevenue);
        gB1.Controls.Add(lblRevenue);
        gB1.Location = new Point(47, 83);
        gB1.Name = "gB1";
        gB1.Size = new Size(750, 491);
        gB1.TabIndex = 4;
        gB1.TabStop = false;
        gB1.Visible = false;
        // 
        // dG1
        // 
        dG1.AllowUserToAddRows = false;
        dG1.AllowUserToDeleteRows = false;
        dG1.AllowUserToResizeColumns = false;
        dG1.AllowUserToResizeRows = false;
        dG1.BackgroundColor = Color.WhiteSmoke;
        dG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dG1.Columns.AddRange(new DataGridViewColumn[] { ProductName, SalesQuantity, ProductAmount });
        dG1.EditMode = DataGridViewEditMode.EditProgrammatically;
        dG1.Location = new Point(18, 177);
        dG1.Name = "dG1";
        dG1.RowHeadersVisible = false;
        dG1.RowHeadersWidth = 51;
        dG1.RowTemplate.Height = 29;
        dG1.Size = new Size(712, 308);
        dG1.TabIndex = 3;
        // 
        // ProductName
        // 
        ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ProductName.HeaderText = "Ürün Adı";
        ProductName.MinimumWidth = 6;
        ProductName.Name = "ProductName";
        // 
        // SalesQuantity
        // 
        SalesQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        SalesQuantity.HeaderText = "Satış Adedi";
        SalesQuantity.MinimumWidth = 6;
        SalesQuantity.Name = "SalesQuantity";
        // 
        // ProductAmount
        // 
        ProductAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        ProductAmount.HeaderText = "Ürün Kazancı";
        ProductAmount.MinimumWidth = 6;
        ProductAmount.Name = "ProductAmount";
        // 
        // lbCashRevenue
        // 
        lbCashRevenue.AutoSize = true;
        lbCashRevenue.Location = new Point(16, 122);
        lbCashRevenue.Name = "lbCashRevenue";
        lbCashRevenue.Size = new Size(226, 33);
        lbCashRevenue.TabIndex = 2;
        lbCashRevenue.Text = "Nakit Ciro: 5000 ₺";
        // 
        // lbCreditCartRevenue
        // 
        lbCreditCartRevenue.AutoSize = true;
        lbCreditCartRevenue.Location = new Point(16, 75);
        lbCreditCartRevenue.Name = "lbCreditCartRevenue";
        lbCreditCartRevenue.Size = new Size(289, 33);
        lbCreditCartRevenue.TabIndex = 1;
        lbCreditCartRevenue.Text = "Kredi Kartı Ciro: 5000 ₺";
        // 
        // lblRevenue
        // 
        lblRevenue.AutoSize = true;
        lblRevenue.Location = new Point(16, 32);
        lblRevenue.Name = "lblRevenue";
        lblRevenue.Size = new Size(246, 33);
        lblRevenue.TabIndex = 0;
        lblRevenue.Text = "Toplam Ciro: 5000 ₺";
        // 
        // btnReport
        // 
        btnReport.Location = new Point(589, 21);
        btnReport.Name = "btnReport";
        btnReport.Size = new Size(208, 39);
        btnReport.TabIndex = 2;
        btnReport.Text = "Rapor Oluştur";
        btnReport.UseVisualStyleBackColor = true;
        btnReport.Click += btnReport_Click;
        // 
        // dPEnd
        // 
        dPEnd.Location = new Point(311, 21);
        dPEnd.Name = "dPEnd";
        dPEnd.Size = new Size(250, 39);
        dPEnd.TabIndex = 1;
        // 
        // dPStart
        // 
        dPStart.Location = new Point(44, 21);
        dPStart.Name = "dPStart";
        dPStart.Size = new Size(250, 39);
        dPStart.TabIndex = 0;
        // 
        // contextMenuStrip1
        // 
        contextMenuStrip1.ImageScalingSize = new Size(20, 20);
        contextMenuStrip1.Name = "contextMenuStrip1";
        contextMenuStrip1.Size = new Size(61, 4);
        // 
        // btnExportExcel
        // 
        btnExportExcel.Location = new Point(505, 22);
        btnExportExcel.Name = "btnExportExcel";
        btnExportExcel.Size = new Size(198, 67);
        btnExportExcel.TabIndex = 4;
        btnExportExcel.Text = "Excel'e Aktar";
        btnExportExcel.UseVisualStyleBackColor = true;
        btnExportExcel.Click += btnExportExcel_Click;
        // 
        // FrmReport
        // 
        AutoScaleDimensions = new SizeF(15F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1321, 656);
        Controls.Add(tabControl1);
        Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(6, 5, 6, 5);
        Name = "FrmReport";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmReport";
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        gB1.ResumeLayout(false);
        gB1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dG1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControl1;
    private TabPage tabPage1;
    private GroupBox gB1;
    private DataGridView dG1;
    private Label lbCashRevenue;
    private Label lbCreditCartRevenue;
    private Label lblRevenue;
    private Button btnReport;
    private DateTimePicker dPEnd;
    private DateTimePicker dPStart;
    private ContextMenuStrip contextMenuStrip1;
    private DataGridViewTextBoxColumn ProductName;
    private DataGridViewTextBoxColumn SalesQuantity;
    private DataGridViewTextBoxColumn ProductAmount;
    private Button btnExportExcel;
}