namespace MyRestaurantApp;

partial class FrmProductVariants
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
        lstMenu = new ListBox();
        SuspendLayout();
        // 
        // lstMenu
        // 
        lstMenu.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
        lstMenu.FormattingEnabled = true;
        lstMenu.ItemHeight = 46;
        lstMenu.Location = new Point(12, 12);
        lstMenu.Name = "lstMenu";
        lstMenu.Size = new Size(410, 418);
        lstMenu.TabIndex = 2;
        lstMenu.MouseDoubleClick += lstMenu_MouseDoubleClick;
        // 
        // FrmProductVariants
        // 
        AutoScaleDimensions = new SizeF(14F, 36F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(434, 438);
        Controls.Add(lstMenu);
        Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5, 6, 5, 6);
        Name = "FrmProductVariants";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ürün Varyantları";
        FormClosed += FrmProductVariants_FormClosed;
        ResumeLayout(false);
    }

    #endregion

    private ListBox lstMenu;
}