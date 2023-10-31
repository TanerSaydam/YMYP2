namespace MyRestaurantApp;

partial class FrmPayment
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
        lbTotal = new Label();
        txtCash = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtCC = new TextBox();
        btnMakeThePayment = new Button();
        label3 = new Label();
        txtCCOwner = new TextBox();
        label4 = new Label();
        txtCCNumber1 = new TextBox();
        txtCCNumber2 = new TextBox();
        txtCCNumber3 = new TextBox();
        txtCCNumber4 = new TextBox();
        gbCC = new GroupBox();
        label6 = new Label();
        txtCVC = new TextBox();
        txtExpireMounth = new TextBox();
        label5 = new Label();
        txtExpireYear = new TextBox();
        cbCC = new CheckBox();
        gbCC.SuspendLayout();
        SuspendLayout();
        // 
        // lbTotal
        // 
        lbTotal.BackColor = Color.IndianRed;
        lbTotal.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
        lbTotal.ForeColor = Color.White;
        lbTotal.Location = new Point(12, 9);
        lbTotal.Name = "lbTotal";
        lbTotal.Size = new Size(353, 79);
        lbTotal.TabIndex = 2;
        lbTotal.Text = "100,00 ₺";
        lbTotal.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // txtCash
        // 
        txtCash.Location = new Point(18, 134);
        txtCash.Name = "txtCash";
        txtCash.Size = new Size(340, 38);
        txtCash.TabIndex = 3;
        txtCash.Text = "0";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 100);
        label1.Name = "label1";
        label1.Size = new Size(73, 31);
        label1.TabIndex = 4;
        label1.Text = "Nakit";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 257);
        label2.Name = "label2";
        label2.Size = new Size(72, 31);
        label2.TabIndex = 6;
        label2.Text = "Tutar";
        // 
        // txtCC
        // 
        txtCC.Location = new Point(6, 283);
        txtCC.Name = "txtCC";
        txtCC.Size = new Size(326, 38);
        txtCC.TabIndex = 5;
        txtCC.Text = "0";
        // 
        // btnMakeThePayment
        // 
        btnMakeThePayment.BackColor = Color.Moccasin;
        btnMakeThePayment.Location = new Point(12, 554);
        btnMakeThePayment.Name = "btnMakeThePayment";
        btnMakeThePayment.Size = new Size(357, 47);
        btnMakeThePayment.TabIndex = 7;
        btnMakeThePayment.Text = "Ödeme Yap";
        btnMakeThePayment.UseVisualStyleBackColor = false;
        btnMakeThePayment.Click += btnMakeThePayment_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 29);
        label3.Name = "label3";
        label3.Size = new Size(184, 31);
        label3.TabIndex = 9;
        label3.Text = "Kart Sahibi Adı";
        // 
        // txtCCOwner
        // 
        txtCCOwner.Location = new Point(6, 55);
        txtCCOwner.Name = "txtCCOwner";
        txtCCOwner.Size = new Size(326, 38);
        txtCCOwner.TabIndex = 8;
        txtCCOwner.Text = "John Doe";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 99);
        label4.Name = "label4";
        label4.Size = new Size(172, 31);
        label4.TabIndex = 11;
        label4.Text = "Kart Numarası";
        // 
        // txtCCNumber1
        // 
        txtCCNumber1.Location = new Point(6, 125);
        txtCCNumber1.Name = "txtCCNumber1";
        txtCCNumber1.Size = new Size(79, 38);
        txtCCNumber1.TabIndex = 10;
        txtCCNumber1.Text = "5528";
        // 
        // txtCCNumber2
        // 
        txtCCNumber2.Location = new Point(91, 125);
        txtCCNumber2.Name = "txtCCNumber2";
        txtCCNumber2.Size = new Size(79, 38);
        txtCCNumber2.TabIndex = 12;
        txtCCNumber2.Text = "7900";
        // 
        // txtCCNumber3
        // 
        txtCCNumber3.Location = new Point(176, 125);
        txtCCNumber3.Name = "txtCCNumber3";
        txtCCNumber3.Size = new Size(79, 38);
        txtCCNumber3.TabIndex = 13;
        txtCCNumber3.Text = "0000";
        // 
        // txtCCNumber4
        // 
        txtCCNumber4.Location = new Point(261, 125);
        txtCCNumber4.Name = "txtCCNumber4";
        txtCCNumber4.Size = new Size(79, 38);
        txtCCNumber4.TabIndex = 14;
        txtCCNumber4.Text = "0008";
        // 
        // gbCC
        // 
        gbCC.Controls.Add(label6);
        gbCC.Controls.Add(label2);
        gbCC.Controls.Add(txtCVC);
        gbCC.Controls.Add(txtCC);
        gbCC.Controls.Add(txtExpireMounth);
        gbCC.Controls.Add(label5);
        gbCC.Controls.Add(txtExpireYear);
        gbCC.Controls.Add(label3);
        gbCC.Controls.Add(txtCCNumber4);
        gbCC.Controls.Add(txtCCOwner);
        gbCC.Controls.Add(txtCCNumber1);
        gbCC.Controls.Add(txtCCNumber3);
        gbCC.Controls.Add(label4);
        gbCC.Controls.Add(txtCCNumber2);
        gbCC.Location = new Point(12, 205);
        gbCC.Name = "gbCC";
        gbCC.Size = new Size(353, 332);
        gbCC.TabIndex = 15;
        gbCC.TabStop = false;
        gbCC.Text = "Kredi Kartı";
        gbCC.Visible = false;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(209, 171);
        label6.Name = "label6";
        label6.Size = new Size(69, 31);
        label6.TabIndex = 19;
        label6.Text = "CVC";
        // 
        // txtCVC
        // 
        txtCVC.Location = new Point(210, 197);
        txtCVC.Name = "txtCVC";
        txtCVC.Size = new Size(79, 38);
        txtCVC.TabIndex = 18;
        txtCVC.Text = "123";
        // 
        // txtExpireMounth
        // 
        txtExpireMounth.Location = new Point(6, 197);
        txtExpireMounth.Name = "txtExpireMounth";
        txtExpireMounth.Size = new Size(79, 38);
        txtExpireMounth.TabIndex = 15;
        txtExpireMounth.Text = "12";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(6, 171);
        label5.Name = "label5";
        label5.Size = new Size(182, 31);
        label5.TabIndex = 16;
        label5.Text = "Son Kul. Tarihi";
        // 
        // txtExpireYear
        // 
        txtExpireYear.Location = new Point(91, 197);
        txtExpireYear.Name = "txtExpireYear";
        txtExpireYear.Size = new Size(79, 38);
        txtExpireYear.TabIndex = 17;
        txtExpireYear.Text = "2030";
        // 
        // cbCC
        // 
        cbCC.AutoSize = true;
        cbCC.Location = new Point(18, 164);
        cbCC.Name = "cbCC";
        cbCC.Size = new Size(200, 35);
        cbCC.TabIndex = 20;
        cbCC.Text = "K.K İle Ödeme";
        cbCC.UseVisualStyleBackColor = true;
        cbCC.CheckedChanged += cbCC_CheckedChanged;
        // 
        // FrmPayment
        // 
        AutoScaleDimensions = new SizeF(14F, 29F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(381, 613);
        Controls.Add(btnMakeThePayment);
        Controls.Add(cbCC);
        Controls.Add(label1);
        Controls.Add(txtCash);
        Controls.Add(lbTotal);
        Controls.Add(gbCC);
        Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5);
        Name = "FrmPayment";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "FrmPayment";
        Load += FrmPayment_Load;
        gbCC.ResumeLayout(false);
        gbCC.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbTotal;
    private TextBox txtCash;
    private Label label1;
    private Label label2;
    private TextBox txtCC;
    private Button btnMakeThePayment;
    private Label label3;
    private TextBox txtCCOwner;
    private Label label4;
    private TextBox txtCCNumber1;
    private TextBox txtCCNumber2;
    private TextBox txtCCNumber3;
    private TextBox txtCCNumber4;
    private GroupBox gbCC;
    private Label label6;
    private TextBox txtCVC;
    private TextBox txtExpireMounth;
    private Label label5;
    private TextBox txtExpireYear;
    private CheckBox cbCC;
}