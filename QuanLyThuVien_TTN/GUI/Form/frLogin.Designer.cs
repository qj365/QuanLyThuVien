namespace QuanLyThuVien_TTN
{
    partial class frLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.iconButtonPassword = new FontAwesome.Sharp.IconButton();
            this.panelUser = new System.Windows.Forms.Panel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.iconButtonUser = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPassword.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(293, 305);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(211, 71);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkBox1.Location = new System.Drawing.Point(215, 249);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 23);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Controls.Add(this.iconButtonPassword);
            this.panelPassword.Location = new System.Drawing.Point(215, 166);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(370, 57);
            this.panelPassword.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxPassword.Location = new System.Drawing.Point(56, 14);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(313, 29);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.Text = "Mật khẩu";
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // iconButtonPassword
            // 
            this.iconButtonPassword.FlatAppearance.BorderSize = 0;
            this.iconButtonPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButtonPassword.IconColor = System.Drawing.Color.Black;
            this.iconButtonPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPassword.IconSize = 40;
            this.iconButtonPassword.Location = new System.Drawing.Point(14, 8);
            this.iconButtonPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonPassword.Name = "iconButtonPassword";
            this.iconButtonPassword.Size = new System.Drawing.Size(38, 41);
            this.iconButtonPassword.TabIndex = 9;
            this.iconButtonPassword.TabStop = false;
            this.iconButtonPassword.UseVisualStyleBackColor = true;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelUser.Controls.Add(this.textBoxUser);
            this.panelUser.Controls.Add(this.iconButtonUser);
            this.panelUser.Location = new System.Drawing.Point(215, 75);
            this.panelUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(370, 57);
            this.panelUser.TabIndex = 11;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxUser.Location = new System.Drawing.Point(58, 16);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(310, 29);
            this.textBoxUser.TabIndex = 6;
            this.textBoxUser.Text = "Tài khoản";
            this.textBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUser_KeyDown);
            // 
            // iconButtonUser
            // 
            this.iconButtonUser.FlatAppearance.BorderSize = 0;
            this.iconButtonUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.iconButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButtonUser.IconColor = System.Drawing.Color.Black;
            this.iconButtonUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUser.IconSize = 40;
            this.iconButtonUser.Location = new System.Drawing.Point(14, 8);
            this.iconButtonUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButtonUser.Name = "iconButtonUser";
            this.iconButtonUser.Size = new System.Drawing.Size(38, 41);
            this.iconButtonUser.TabIndex = 5;
            this.iconButtonUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sign in";
            // 
            // frLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelUser);
            this.Name = "frLogin";
            this.Text = "frLogin";
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private FontAwesome.Sharp.IconButton iconButtonPassword;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private FontAwesome.Sharp.IconButton iconButtonUser;
        private System.Windows.Forms.Label label1;
    }
}