namespace GroupProject
{
    partial class MainForm
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
            panel1 = new Panel();
            btnExit = new Button();
            btnProduct = new Button();
            btnCategory = new Button();
            btnAccount = new Button();
            panel2 = new Panel();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnProduct);
            panel1.Controls.Add(btnCategory);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 606);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Dock = DockStyle.Top;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(0, 414);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 72);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnProduct.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.ForeColor = SystemColors.ButtonHighlight;
            btnProduct.Location = new Point(0, 342);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(250, 72);
            btnProduct.TabIndex = 2;
            btnProduct.Text = "Quản lý sản phẩm";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.Transparent;
            btnCategory.Dock = DockStyle.Top;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnCategory.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.ForeColor = SystemColors.ButtonHighlight;
            btnCategory.Location = new Point(0, 270);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(250, 72);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "Quản lý Danh Mục";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.Transparent;
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnAccount.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.ForeColor = SystemColors.ButtonHighlight;
            btnAccount.Location = new Point(0, 198);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(250, 72);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Quản lý tài khoản";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 198);
            panel2.TabIndex = 0;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(988, 606);
            panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 606);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "MainForm";
            FormClosed += MainForm_FormClosed;
            Load += TabForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAccount;
        private Panel panel2;
        private Panel panelMain;
        private Button btnExit;
        private Button btnProduct;
        private Button btnCategory;
    }
}