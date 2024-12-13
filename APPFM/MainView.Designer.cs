namespace APPFM
{
    partial class MainView
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
            btnBanhang = new Button();
            panel2 = new Panel();
            button1 = new Button();
            btnThoat = new Button();
            btnDonHang = new Button();
            btnKho = new Button();
            btnTrangchu = new Button();
            pictureBox1 = new PictureBox();
            panel_NoiDung = new Panel();
            textBox1 = new TextBox();
            lblHome = new Label();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_NoiDung.SuspendLayout();
            SuspendLayout();
            // 
            // btnBanhang
            // 
            btnBanhang.Location = new Point(0, 205);
            btnBanhang.Name = "btnBanhang";
            btnBanhang.Size = new Size(203, 53);
            btnBanhang.TabIndex = 2;
            btnBanhang.Text = "Bán hàng";
            btnBanhang.UseVisualStyleBackColor = true;
            btnBanhang.Click += btnBanhang_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnDonHang);
            panel2.Controls.Add(btnKho);
            panel2.Controls.Add(btnBanhang);
            panel2.Controls.Add(btnTrangchu);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 748);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(46, 694);
            button1.Name = "button1";
            button1.Size = new Size(112, 42);
            button1.TabIndex = 6;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(0, 440);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(203, 53);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDonHang
            // 
            btnDonHang.Location = new Point(0, 361);
            btnDonHang.Name = "btnDonHang";
            btnDonHang.Size = new Size(203, 53);
            btnDonHang.TabIndex = 4;
            btnDonHang.Text = "Đơn Hàng";
            btnDonHang.UseVisualStyleBackColor = true;
            btnDonHang.Click += btnDonHang_Click;
            // 
            // btnKho
            // 
            btnKho.Location = new Point(0, 280);
            btnKho.Name = "btnKho";
            btnKho.Size = new Size(203, 53);
            btnKho.TabIndex = 3;
            btnKho.Text = "Kho hàng";
            btnKho.UseVisualStyleBackColor = true;
            btnKho.Click += btnKho_Click;
            // 
            // btnTrangchu
            // 
            btnTrangchu.Location = new Point(0, 131);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Size = new Size(203, 53);
            btnTrangchu.TabIndex = 1;
            btnTrangchu.Text = "Trang chủ";
            btnTrangchu.UseVisualStyleBackColor = true;
            btnTrangchu.Click += btnTrangchu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(46, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_NoiDung
            // 
            panel_NoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_NoiDung.Controls.Add(textBox1);
            panel_NoiDung.Location = new Point(210, 42);
            panel_NoiDung.Name = "panel_NoiDung";
            panel_NoiDung.Size = new Size(1011, 706);
            panel_NoiDung.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1030, -36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 35);
            textBox1.TabIndex = 7;
            // 
            // lblHome
            // 
            lblHome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHome.AutoSize = true;
            lblHome.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHome.Location = new Point(641, 9);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(107, 30);
            lblHome.TabIndex = 4;
            lblHome.Text = "Trang chủ";
            lblHome.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 661);
            label1.Name = "label1";
            label1.Size = new Size(45, 30);
            label1.TabIndex = 6;
            label1.Text = "Tên";
            label1.Click += label1_Click;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 748);
            Controls.Add(lblHome);
            Controls.Add(panel2);
            Controls.Add(panel_NoiDung);
            Name = "MainView";
            Text = "MainView";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_NoiDung.ResumeLayout(false);
            panel_NoiDung.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBanhang;
        private Panel panel2;
        private Button btnThoat;
        private Button btnDonHang;
        private Button btnKho;
        private Button btnTrangchu;
        private PictureBox pictureBox1;
        private Panel panel_NoiDung;
        private Label lblHome;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}