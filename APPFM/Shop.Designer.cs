namespace APPFM
{
    partial class Shop
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label8 = new Label();
            textBox5 = new TextBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            checkOutViewModelBindingSource = new BindingSource(components);
            textBox4 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkOutViewModelBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1001, 656);
            panel1.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(615, 531);
            label8.Name = "label8";
            label8.Size = new Size(107, 30);
            label8.TabIndex = 18;
            label8.Text = "Số lượng :";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(643, 672);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(224, 35);
            textBox5.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(9, 315);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(590, 341);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giỏ hàng";
            // 
            // button3
            // 
            button3.Location = new Point(355, 270);
            button3.Name = "button3";
            button3.Size = new Size(97, 39);
            button3.TabIndex = 9;
            button3.Text = "Đặt hàng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(72, 270);
            button2.Name = "button2";
            button2.Size = new Size(97, 39);
            button2.TabIndex = 8;
            button2.Text = "Xóa giỏ hàng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridView2.DataSource = checkOutViewModelBindingSource;
            dataGridView2.Location = new Point(0, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(590, 227);
            dataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // checkOutViewModelBindingSource
            // 
            checkOutViewModelBindingSource.DataSource = typeof(DTO.Viewmodel.CheckOutViewModel);
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(157, 15);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 35);
            textBox4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 20);
            label3.Name = "label3";
            label3.Size = new Size(142, 30);
            label3.TabIndex = 5;
            label3.Text = "Tên sản phẩm";
            // 
            // button1
            // 
            button1.Location = new Point(399, 15);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 4;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(602, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(399, 513);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin sản phẩm";
            // 
            // button4
            // 
            button4.Location = new Point(199, 452);
            button4.Name = "button4";
            button4.Size = new Size(130, 39);
            button4.TabIndex = 10;
            button4.Text = "Thêm giỏ hàng";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(41, 75);
            label7.Name = "label7";
            label7.Size = new Size(109, 30);
            label7.TabIndex = 16;
            label7.Text = "Hình ảnh :";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(154, 385);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(224, 38);
            comboBox2.TabIndex = 15;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(89, 393);
            label6.Name = "label6";
            label6.Size = new Size(61, 30);
            label6.TabIndex = 14;
            label6.Text = "Size :";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 331);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 38);
            comboBox1.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(89, 339);
            label5.Name = "label5";
            label5.Size = new Size(66, 30);
            label5.TabIndex = 12;
            label5.Text = "Màu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 285);
            label4.Name = "label4";
            label4.Size = new Size(107, 30);
            label4.TabIndex = 10;
            label4.Text = "Số lượng :";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(154, 282);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 35);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(154, 229);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 35);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(101, 232);
            label1.Name = "label1";
            label1.Size = new Size(54, 30);
            label1.TabIndex = 6;
            label1.Text = "Giá :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(154, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 35);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 183);
            label2.Name = "label2";
            label2.Size = new Size(153, 30);
            label2.TabIndex = 4;
            label2.Text = "Tên sản phẩm :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(161, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(3, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 253);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(590, 227);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DTO.Product);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(615, 585);
            label9.Name = "label9";
            label9.Size = new Size(112, 30);
            label9.TabIndex = 19;
            label9.Text = "Tổng tiền :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(733, 585);
            label10.Name = "label10";
            label10.Size = new Size(24, 30);
            label10.TabIndex = 20;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(731, 531);
            label11.Name = "label11";
            label11.Size = new Size(24, 30);
            label11.TabIndex = 21;
            label11.Text = "0";
            // 
            // Shop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 655);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Shop";
            Text = "Shop";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkOutViewModelBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label3;
        private Button button1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label7;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private Button button3;
        private Button button2;
        private Button button4;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private BindingSource checkOutViewModelBindingSource;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}