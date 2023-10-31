namespace MyRestaurantApp;

partial class FrmRestaurant
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
        menuStrip1 = new MenuStrip();
        ayarlarToolStripMenuItem = new ToolStripMenuItem();
        ürünEkleToolStripMenuItem = new ToolStripMenuItem();
        başlangıçToolStripMenuItem = new ToolStripMenuItem();
        seedDataEkleToolStripMenuItem = new ToolStripMenuItem();
        raporlarToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { ayarlarToolStripMenuItem, başlangıçToolStripMenuItem, raporlarToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1924, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // ayarlarToolStripMenuItem
        // 
        ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünEkleToolStripMenuItem });
        ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
        ayarlarToolStripMenuItem.Size = new Size(70, 24);
        ayarlarToolStripMenuItem.Text = "Ayarlar";
        // 
        // ürünEkleToolStripMenuItem
        // 
        ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
        ürünEkleToolStripMenuItem.Size = new Size(224, 26);
        ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
        ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
        // 
        // başlangıçToolStripMenuItem
        // 
        başlangıçToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seedDataEkleToolStripMenuItem });
        başlangıçToolStripMenuItem.Name = "başlangıçToolStripMenuItem";
        başlangıçToolStripMenuItem.Size = new Size(86, 24);
        başlangıçToolStripMenuItem.Text = "Başlangıç";
        // 
        // seedDataEkleToolStripMenuItem
        // 
        seedDataEkleToolStripMenuItem.Name = "seedDataEkleToolStripMenuItem";
        seedDataEkleToolStripMenuItem.Size = new Size(192, 26);
        seedDataEkleToolStripMenuItem.Text = "Seed Data Ekle";
        seedDataEkleToolStripMenuItem.Click += seedDataEkleToolStripMenuItem_Click;
        // 
        // raporlarToolStripMenuItem
        // 
        raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
        raporlarToolStripMenuItem.Size = new Size(80, 24);
        raporlarToolStripMenuItem.Text = "Raporlar";
        raporlarToolStripMenuItem.Click += raporlarToolStripMenuItem_Click;
        // 
        // FrmRestaurant
        // 
        AutoScaleDimensions = new SizeF(14F, 29F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(1924, 1055);
        Controls.Add(menuStrip1);
        Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(5);
        Name = "FrmRestaurant";
        Text = "Restraurant";
        WindowState = FormWindowState.Maximized;
        Load += Form1_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem ayarlarToolStripMenuItem;
    private ToolStripMenuItem ürünEkleToolStripMenuItem;
    private ToolStripMenuItem başlangıçToolStripMenuItem;
    private ToolStripMenuItem seedDataEkleToolStripMenuItem;
    private ToolStripMenuItem raporlarToolStripMenuItem;
}
