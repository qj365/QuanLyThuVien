namespace QuanLyThuVien_TTN
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonMuonSach = new FontAwesome.Sharp.IconButton();
            this.iconButtonDocGia = new FontAwesome.Sharp.IconButton();
            this.iconButtonNhanVien = new FontAwesome.Sharp.IconButton();
            this.iconButtonSach = new FontAwesome.Sharp.IconButton();
            this.iconButtonTheThuVien = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDesktop.Location = new System.Drawing.Point(311, 74);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(5);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1405, 738);
            this.panelDesktop.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.panelMenu.Controls.Add(this.iconButtonMuonSach);
            this.panelMenu.Controls.Add(this.iconButtonDocGia);
            this.panelMenu.Controls.Add(this.iconButtonNhanVien);
            this.panelMenu.Controls.Add(this.iconButtonSach);
            this.panelMenu.Controls.Add(this.iconButtonTheThuVien);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 74);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(311, 740);
            this.panelMenu.TabIndex = 4;
            // 
            // iconButtonMuonSach
            // 
            this.iconButtonMuonSach.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonMuonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMuonSach.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMuonSach.ForeColor = System.Drawing.Color.White;
            this.iconButtonMuonSach.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButtonMuonSach.IconColor = System.Drawing.Color.White;
            this.iconButtonMuonSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMuonSach.IconSize = 36;
            this.iconButtonMuonSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMuonSach.Location = new System.Drawing.Point(14, 333);
            this.iconButtonMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonMuonSach.Name = "iconButtonMuonSach";
            this.iconButtonMuonSach.Size = new System.Drawing.Size(283, 74);
            this.iconButtonMuonSach.TabIndex = 9;
            this.iconButtonMuonSach.Text = "MUỢN SÁCH";
            this.iconButtonMuonSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMuonSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMuonSach.UseVisualStyleBackColor = false;
            this.iconButtonMuonSach.Click += new System.EventHandler(this.iconButtonMuonSach_Click);
            // 
            // iconButtonDocGia
            // 
            this.iconButtonDocGia.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDocGia.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDocGia.ForeColor = System.Drawing.Color.White;
            this.iconButtonDocGia.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconButtonDocGia.IconColor = System.Drawing.Color.White;
            this.iconButtonDocGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDocGia.IconSize = 36;
            this.iconButtonDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDocGia.Location = new System.Drawing.Point(16, 90);
            this.iconButtonDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonDocGia.Name = "iconButtonDocGia";
            this.iconButtonDocGia.Size = new System.Drawing.Size(283, 74);
            this.iconButtonDocGia.TabIndex = 6;
            this.iconButtonDocGia.Text = "ĐỘC GIẢ";
            this.iconButtonDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDocGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDocGia.UseVisualStyleBackColor = false;
            this.iconButtonDocGia.Click += new System.EventHandler(this.iconButtonDocGia_Click);
            // 
            // iconButtonNhanVien
            // 
            this.iconButtonNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonNhanVien.ForeColor = System.Drawing.Color.White;
            this.iconButtonNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButtonNhanVien.IconColor = System.Drawing.Color.White;
            this.iconButtonNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNhanVien.IconSize = 36;
            this.iconButtonNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNhanVien.Location = new System.Drawing.Point(16, 252);
            this.iconButtonNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonNhanVien.Name = "iconButtonNhanVien";
            this.iconButtonNhanVien.Size = new System.Drawing.Size(283, 74);
            this.iconButtonNhanVien.TabIndex = 8;
            this.iconButtonNhanVien.Text = "NHÂN VIÊN";
            this.iconButtonNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonNhanVien.UseVisualStyleBackColor = false;
            this.iconButtonNhanVien.Click += new System.EventHandler(this.iconButtonNhanVien_Click);
            // 
            // iconButtonSach
            // 
            this.iconButtonSach.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSach.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSach.ForeColor = System.Drawing.Color.White;
            this.iconButtonSach.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButtonSach.IconColor = System.Drawing.Color.White;
            this.iconButtonSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSach.IconSize = 36;
            this.iconButtonSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSach.Location = new System.Drawing.Point(16, 9);
            this.iconButtonSach.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSach.Name = "iconButtonSach";
            this.iconButtonSach.Size = new System.Drawing.Size(283, 74);
            this.iconButtonSach.TabIndex = 5;
            this.iconButtonSach.Text = "SÁCH";
            this.iconButtonSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSach.UseVisualStyleBackColor = false;
            this.iconButtonSach.Click += new System.EventHandler(this.iconButtonSach_Click);
            // 
            // iconButtonTheThuVien
            // 
            this.iconButtonTheThuVien.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonTheThuVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonTheThuVien.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonTheThuVien.ForeColor = System.Drawing.Color.White;
            this.iconButtonTheThuVien.IconChar = FontAwesome.Sharp.IconChar.IdCardAlt;
            this.iconButtonTheThuVien.IconColor = System.Drawing.Color.White;
            this.iconButtonTheThuVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonTheThuVien.IconSize = 36;
            this.iconButtonTheThuVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTheThuVien.Location = new System.Drawing.Point(16, 171);
            this.iconButtonTheThuVien.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonTheThuVien.Name = "iconButtonTheThuVien";
            this.iconButtonTheThuVien.Size = new System.Drawing.Size(283, 74);
            this.iconButtonTheThuVien.TabIndex = 7;
            this.iconButtonTheThuVien.Text = "THẺ THƯ VIỆN";
            this.iconButtonTheThuVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTheThuVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonTheThuVien.UseVisualStyleBackColor = false;
            this.iconButtonTheThuVien.Click += new System.EventHandler(this.iconButtonTheThuVien_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1375, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(138)))), ((int)(((byte)(195)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1724, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 74);
            this.panel2.TabIndex = 4;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(777, 14);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(171, 38);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "TRANG CHỦ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thư Viện MTA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.lblTime);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1731, 74);
            this.panelTop.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1585, 26);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 25);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "HH:MM:SS";
            // 
            // timerClock
            // 
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick_1);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 814);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "Thư viện MTA";
            this.panelMenu.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconButton iconButtonNhanVien;
        private FontAwesome.Sharp.IconButton iconButtonTheThuVien;
        private FontAwesome.Sharp.IconButton iconButtonDocGia;
        private FontAwesome.Sharp.IconButton iconButtonSach;
        private System.Windows.Forms.Label lblTime;
        private FontAwesome.Sharp.IconButton iconButtonMuonSach;
        private System.Windows.Forms.Timer timerClock;
    }
}

