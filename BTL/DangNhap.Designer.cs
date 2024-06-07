namespace BTL
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.bttDangNhap = new System.Windows.Forms.Button();
            this.picbNhinMatKhau = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbNhinMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần Mềm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(130, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "QUẢN LÝ CÔNG VĂN KHOA CNTT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(68, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "vui lòng điền thông tin bên dưới để đăng nhập";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtTaiKhoan.Location = new System.Drawing.Point(71, 126);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(280, 22);
            this.txtTaiKhoan.TabIndex = 4;
            this.txtTaiKhoan.TabStop = false;
            this.txtTaiKhoan.Text = "Nhập tên tài khoản";
            this.txtTaiKhoan.Enter += new System.EventHandler(this.txtTaiKhoan_Enter);
            this.txtTaiKhoan.Leave += new System.EventHandler(this.txtTaiKhoan_Leave);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtMatKhau.Location = new System.Drawing.Point(71, 171);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(249, 22);
            this.txtMatKhau.TabIndex = 5;
            this.txtMatKhau.TabStop = false;
            this.txtMatKhau.Text = "Nhập mật khẩu";
            this.txtMatKhau.Enter += new System.EventHandler(this.txtMatKhau_Enter);
            this.txtMatKhau.Leave += new System.EventHandler(this.txtMatKhau_Leave);
            // 
            // bttDangNhap
            // 
            this.bttDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bttDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttDangNhap.ForeColor = System.Drawing.Color.White;
            this.bttDangNhap.Location = new System.Drawing.Point(71, 213);
            this.bttDangNhap.Name = "bttDangNhap";
            this.bttDangNhap.Size = new System.Drawing.Size(280, 42);
            this.bttDangNhap.TabIndex = 6;
            this.bttDangNhap.Text = "Đăng nhập";
            this.bttDangNhap.UseVisualStyleBackColor = false;
            this.bttDangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // picbNhinMatKhau
            // 
            this.picbNhinMatKhau.BackColor = System.Drawing.Color.White;
            this.picbNhinMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picbNhinMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbNhinMatKhau.Image = global::BTL.Properties.Resources.pngegg;
            this.picbNhinMatKhau.Location = new System.Drawing.Point(320, 171);
            this.picbNhinMatKhau.Name = "picbNhinMatKhau";
            this.picbNhinMatKhau.Size = new System.Drawing.Size(31, 24);
            this.picbNhinMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbNhinMatKhau.TabIndex = 17;
            this.picbNhinMatKhau.TabStop = false;
            this.picbNhinMatKhau.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::BTL.Properties.Resources.istockphoto_1223066781_1024x10241;
            this.pictureBox1.Location = new System.Drawing.Point(75, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 300);
            this.Controls.Add(this.picbNhinMatKhau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbNhinMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button bttDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbNhinMatKhau;

    }
}

