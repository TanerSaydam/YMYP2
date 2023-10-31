namespace MyRestaurantApp;

partial class FrmAddProduct
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
        label1 = new Label();
        txtName = new TextBox();
        txtPrice = new TextBox();
        label2 = new Label();
        txtVariantName = new TextBox();
        label3 = new Label();
        txtVariantPrice = new TextBox();
        label4 = new Label();
        btnVariantAdd = new Button();
        dG1 = new DataGridView();
        VariantName = new DataGridViewTextBoxColumn();
        VariantPrice = new DataGridViewTextBoxColumn();
        btnSave = new Button();
        ((System.ComponentModel.ISupportInitialize)dG1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(37, 13);
        label1.Name = "label1";
        label1.Size = new Size(118, 33);
        label1.TabIndex = 0;
        label1.Text = "Ürün Adı";
        // 
        // txtName
        // 
        txtName.Location = new Point(37, 49);
        txtName.Name = "txtName";
        txtName.Size = new Size(254, 39);
        txtName.TabIndex = 1;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(314, 49);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(292, 39);
        txtPrice.TabIndex = 3;
        txtPrice.Text = "0";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(314, 9);
        label2.Name = "label2";
        label2.Size = new Size(144, 33);
        label2.TabIndex = 2;
        label2.Text = "Ürün Fiyatı";
        // 
        // txtVariantName
        // 
        txtVariantName.Location = new Point(37, 160);
        txtVariantName.Name = "txtVariantName";
        txtVariantName.Size = new Size(254, 39);
        txtVariantName.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(37, 124);
        label3.Name = "label3";
        label3.Size = new Size(237, 33);
        label3.TabIndex = 4;
        label3.Text = "Ürünün Varyant Adı";
        // 
        // txtVariantPrice
        // 
        txtVariantPrice.Location = new Point(314, 160);
        txtVariantPrice.Name = "txtVariantPrice";
        txtVariantPrice.Size = new Size(292, 39);
        txtVariantPrice.TabIndex = 7;
        txtVariantPrice.Text = "0";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(314, 124);
        label4.Name = "label4";
        label4.Size = new Size(263, 33);
        label4.TabIndex = 6;
        label4.Text = "Ürünün Varyant Fiyatı";
        // 
        // btnVariantAdd
        // 
        btnVariantAdd.Location = new Point(358, 216);
        btnVariantAdd.Name = "btnVariantAdd";
        btnVariantAdd.Size = new Size(248, 50);
        btnVariantAdd.TabIndex = 8;
        btnVariantAdd.Text = "Varyant Ekle";
        btnVariantAdd.UseVisualStyleBackColor = true;
        btnVariantAdd.Click += btnVariantAdd_Click;
        // 
        // dG1
        // 
        dG1.AllowUserToAddRows = false;
        dG1.AllowUserToDeleteRows = false;
        dG1.AllowUserToResizeColumns = false;
        dG1.AllowUserToResizeRows = false;
        dG1.BackgroundColor = Color.WhiteSmoke;
        dG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dG1.Columns.AddRange(new DataGridViewColumn[] { VariantName, VariantPrice });
        dG1.EditMode = DataGridViewEditMode.EditProgrammatically;
        dG1.Location = new Point(37, 288);
        dG1.Name = "dG1";
        dG1.RowHeadersVisible = false;
        dG1.RowHeadersWidth = 51;
        dG1.RowTemplate.Height = 29;
        dG1.Size = new Size(569, 285);
        dG1.TabIndex = 9;
        // 
        // VariantName
        // 
        VariantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        VariantName.HeaderText = "Varyant Adı";
        VariantName.MinimumWidth = 6;
        VariantName.Name = "VariantName";
        // 
        // VariantPrice
        // 
        VariantPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        VariantPrice.HeaderText = "Varyant Ücreti";
        VariantPrice.MinimumWidth = 6;
        VariantPrice.Name = "VariantPrice";
        // 
        // btnSave
        // 
        btnSave.Location = new Point(37, 592);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(569, 50);
        btnSave.TabIndex = 10;
        btnSave.Text = "Kaydet";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // FrmAddProduct
        // 
        AutoScaleDimensions = new SizeF(15F, 31F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(645, 675);
        Controls.Add(btnSave);
        Controls.Add(dG1);
        Controls.Add(btnVariantAdd);
        Controls.Add(txtVariantPrice);
        Controls.Add(label4);
        Controls.Add(txtVariantName);
        Controls.Add(label3);
        Controls.Add(txtPrice);
        Controls.Add(label2);
        Controls.Add(txtName);
        Controls.Add(label1);
        Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(6, 5, 6, 5);
        Name = "FrmAddProduct";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ürün Ekleme Formu";
        ((System.ComponentModel.ISupportInitialize)dG1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtName;
    private TextBox txtPrice;
    private Label label2;
    private TextBox txtVariantName;
    private Label label3;
    private TextBox txtVariantPrice;
    private Label label4;
    private Button btnVariantAdd;
    private DataGridView dG1;
    private DataGridViewTextBoxColumn VariantName;
    private DataGridViewTextBoxColumn VariantPrice;
    private Button btnSave;
}