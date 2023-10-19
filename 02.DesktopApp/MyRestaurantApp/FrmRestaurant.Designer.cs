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
        SuspendLayout();
        // 
        // FrmRestaurant
        // 
        AutoScaleDimensions = new SizeF(12F, 23F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScroll = true;
        ClientSize = new Size(2426, 1061);
        Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        Margin = new Padding(5);
        Name = "FrmRestaurant";
        Text = "Restraurant";
        WindowState = FormWindowState.Maximized;
        Load += Form1_Load;
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
}
