namespace MyFirstDesktop;

partial class Form1
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
        btnSave = new Button();
        label1 = new Label();
        txtWork = new TextBox();
        lstTodos = new ListBox();
        btnUpdate = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // btnSave
        // 
        btnSave.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnSave.Location = new Point(12, 80);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(318, 40);
        btnSave.TabIndex = 0;
        btnSave.Text = "Kaydet";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(104, 6);
        label1.Name = "label1";
        label1.Size = new Size(119, 30);
        label1.TabIndex = 1;
        label1.Text = "Yapılacak İş";
        // 
        // txtWork
        // 
        txtWork.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        txtWork.Location = new Point(12, 39);
        txtWork.Name = "txtWork";
        txtWork.Size = new Size(318, 35);
        txtWork.TabIndex = 2;
        // 
        // lstTodos
        // 
        lstTodos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        lstTodos.FormattingEnabled = true;
        lstTodos.ItemHeight = 30;
        lstTodos.Items.AddRange(new object[] { "asd", "123", "azxc" });
        lstTodos.Location = new Point(12, 122);
        lstTodos.Name = "lstTodos";
        lstTodos.Size = new Size(318, 244);
        lstTodos.TabIndex = 3;
        lstTodos.MouseClick += lstTodos_MouseClick;
        lstTodos.MouseDoubleClick += lstTodos_MouseDoubleClick;
        // 
        // btnUpdate
        // 
        btnUpdate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnUpdate.Location = new Point(12, 80);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(318, 40);
        btnUpdate.TabIndex = 4;
        btnUpdate.Text = "Güncelle";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += button2_Click;
        // 
        // btnCancel
        // 
        btnCancel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnCancel.Location = new Point(12, 126);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(318, 40);
        btnCancel.TabIndex = 5;
        btnCancel.Text = "Vazgeç";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(342, 381);
        Controls.Add(btnCancel);
        Controls.Add(btnUpdate);
        Controls.Add(lstTodos);
        Controls.Add(txtWork);
        Controls.Add(label1);
        Controls.Add(btnSave);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Todo App";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSave;
    private Label label1;
    private TextBox txtWork;
    private ListBox lstTodos;
    private Button btnUpdate;
    private Button btnCancel;
}
