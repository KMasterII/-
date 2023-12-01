namespace BookStore
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.AdminLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UPassTb = new System.Windows.Forms.TextBox();
            this.UNameTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 566);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("幼圆", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(61, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 43);
            this.label7.TabIndex = 4;
            this.label7.Text = "购物无忧";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 43);
            this.label6.TabIndex = 3;
            this.label6.Text = "次日送达";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(61, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 43);
            this.label5.TabIndex = 2;
            this.label5.Text = "正品保障";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.CloseBtn);
            this.panel2.Controls.Add(this.AdminLbl);
            this.panel2.Controls.Add(this.LoginBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.UPassTb);
            this.panel2.Controls.Add(this.UNameTb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(323, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 566);
            this.panel2.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CloseBtn.Location = new System.Drawing.Point(541, 8);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(33, 36);
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.Text = "X";
            this.CloseBtn.Click += new System.EventHandler(this.label8_Click);
            // 
            // AdminLbl
            // 
            this.AdminLbl.AutoSize = true;
            this.AdminLbl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.AdminLbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.AdminLbl.Location = new System.Drawing.Point(217, 517);
            this.AdminLbl.Name = "AdminLbl";
            this.AdminLbl.Size = new System.Drawing.Size(99, 36);
            this.AdminLbl.TabIndex = 8;
            this.AdminLbl.Text = "管理员";
            this.AdminLbl.Click += new System.EventHandler(this.AdminLbl_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.LoginBtn.FlatAppearance.BorderSize = 2;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.LoginBtn.Location = new System.Drawing.Point(178, 415);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(185, 63);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "登录";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(74, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(61, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 41);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户名";
            // 
            // UPassTb
            // 
            this.UPassTb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPassTb.Location = new System.Drawing.Point(198, 301);
            this.UPassTb.Name = "UPassTb";
            this.UPassTb.PasswordChar = '*';
            this.UPassTb.Size = new System.Drawing.Size(287, 50);
            this.UPassTb.TabIndex = 4;
            // 
            // UNameTb
            // 
            this.UNameTb.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameTb.Location = new System.Drawing.Point(198, 222);
            this.UNameTb.Name = "UNameTb";
            this.UNameTb.Size = new System.Drawing.Size(287, 50);
            this.UNameTb.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(176, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "小白书店";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(911, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox UNameTb;
        private Button LoginBtn;
        private Label label3;
        private Label label2;
        private TextBox UPassTb;
        private Label AdminLbl;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label CloseBtn;
    }
}