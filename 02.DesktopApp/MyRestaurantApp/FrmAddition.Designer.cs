namespace MyRestaurantApp;

partial class FrmAddition
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
        lbTableName = new Label();
        groupBox1 = new GroupBox();
        lstMenu = new ListBox();
        txtSearch = new TextBox();
        groupBox2 = new GroupBox();
        lbTotal = new Label();
        lstAddition = new ListBox();
        btnTableIsAvailable = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // lbTableName
        // 
        lbTableName.Font = new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
        lbTableName.Location = new Point(12, 20);
        lbTableName.Name = "lbTableName";
        lbTableName.Size = new Size(911, 41);
        lbTableName.TabIndex = 0;
        lbTableName.Text = "label1";
        lbTableName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lstMenu);
        groupBox1.Controls.Add(txtSearch);
        groupBox1.Location = new Point(14, 71);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(567, 666);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        // 
        // lstMenu
        // 
        lstMenu.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
        lstMenu.FormattingEnabled = true;
        lstMenu.ItemHeight = 36;
        lstMenu.Location = new Point(11, 72);
        lstMenu.Name = "lstMenu";
        lstMenu.Size = new Size(550, 580);
        lstMenu.TabIndex = 1;
        lstMenu.MouseDoubleClick += lstMenu_MouseDoubleClick;
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
        txtSearch.Location = new Point(8, 19);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(553, 44);
        txtSearch.TabIndex = 0;
        txtSearch.TextAlign = HorizontalAlignment.Center;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(lbTotal);
        groupBox2.Controls.Add(lstAddition);
        groupBox2.Location = new Point(594, 71);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(329, 666);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        // 
        // lbTotal
        // 
        lbTotal.BackColor = Color.IndianRed;
        lbTotal.Font = new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
        lbTotal.ForeColor = Color.White;
        lbTotal.Location = new Point(6, 573);
        lbTotal.Name = "lbTotal";
        lbTotal.Size = new Size(317, 79);
        lbTotal.TabIndex = 1;
        lbTotal.Text = "100,00 ₺";
        lbTotal.TextAlign = ContentAlignment.MiddleCenter;
        lbTotal.Click += lbTotal_Click;
        // 
        // lstAddition
        // 
        lstAddition.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
        lstAddition.FormattingEnabled = true;
        lstAddition.ItemHeight = 36;
        lstAddition.Location = new Point(5, 20);
        lstAddition.Name = "lstAddition";
        lstAddition.SelectionMode = SelectionMode.MultiSimple;
        lstAddition.Size = new Size(318, 544);
        lstAddition.TabIndex = 0;
        lstAddition.MouseDoubleClick += lstAddition_MouseDoubleClick;
        // 
        // btnTableIsAvailable
        // 
        btnTableIsAvailable.BackColor = Color.DarkSeaGreen;
        btnTableIsAvailable.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
        btnTableIsAvailable.ForeColor = Color.White;
        btnTableIsAvailable.Location = new Point(705, 11);
        btnTableIsAvailable.Name = "btnTableIsAvailable";
        btnTableIsAvailable.Size = new Size(212, 68);
        btnTableIsAvailable.TabIndex = 3;
        btnTableIsAvailable.Text = "Available";
        btnTableIsAvailable.UseVisualStyleBackColor = false;
        btnTableIsAvailable.Click += btnTableIsAvailable_Click;
        // 
        // FrmAddition
        // 
        AutoScaleDimensions = new SizeF(12F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(935, 749);
        Controls.Add(btnTableIsAvailable);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(lbTableName);
        Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5);
        Name = "FrmAddition";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Addition Form";
        FormClosed += FrmAddition_FormClosed;
        Load += FrmAddition_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label lbTableName;
    private GroupBox groupBox1;
    private TextBox txtSearch;
    private GroupBox groupBox2;
    private ListBox lstMenu;
    private ListBox lstAddition;
    private Label lbTotal;
    private Button btnTableIsAvailable;
}