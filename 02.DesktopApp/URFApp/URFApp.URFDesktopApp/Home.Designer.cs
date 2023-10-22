namespace URFApp.URFDesktopApp;

partial class Home
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnAvisReadExcel = new Button();
        btnLPReadExcel = new Button();
        SuspendLayout();
        // 
        // btnAvisReadExcel
        // 
        btnAvisReadExcel.Location = new Point(33, 19);
        btnAvisReadExcel.Name = "btnAvisReadExcel";
        btnAvisReadExcel.Size = new Size(252, 52);
        btnAvisReadExcel.TabIndex = 0;
        btnAvisReadExcel.Text = "Avis Excel'den Veri Oku";
        btnAvisReadExcel.UseVisualStyleBackColor = true;
        btnAvisReadExcel.Click += btnExcelRead_Click;
        // 
        // btnLPReadExcel
        // 
        btnLPReadExcel.Location = new Point(33, 77);
        btnLPReadExcel.Name = "btnLPReadExcel";
        btnLPReadExcel.Size = new Size(252, 52);
        btnLPReadExcel.TabIndex = 1;
        btnLPReadExcel.Text = "LP Excel'den Veri Oku";
        btnLPReadExcel.UseVisualStyleBackColor = true;
        btnLPReadExcel.Click += btnLPReadExcel_Click;
        // 
        // Home
        // 
        AutoScaleDimensions = new SizeF(12F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(675, 532);
        Controls.Add(btnLPReadExcel);
        Controls.Add(btnAvisReadExcel);
        Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5);
        Name = "Home";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ana Sayfa";
        ResumeLayout(false);
    }

    #endregion

    private Button btnAvisReadExcel;
    private Button btnLPReadExcel;
}
