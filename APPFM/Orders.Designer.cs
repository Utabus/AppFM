namespace APPFM
{
    partial class Orders
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
            dataGridView1 = new DataGridView();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createDayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDescriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderViewModelBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderViewModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { emailDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, totalDataGridViewTextBoxColumn, createDayDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, statusDescriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderViewModelBindingSource;
            dataGridView1.Location = new Point(0, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(986, 484);
            dataGridView1.TabIndex = 1;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // createDayDataGridViewTextBoxColumn
            // 
            createDayDataGridViewTextBoxColumn.DataPropertyName = "CreateDay";
            createDayDataGridViewTextBoxColumn.HeaderText = "CreateDay";
            createDayDataGridViewTextBoxColumn.Name = "createDayDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // statusDescriptionDataGridViewTextBoxColumn
            // 
            statusDescriptionDataGridViewTextBoxColumn.DataPropertyName = "StatusDescription";
            statusDescriptionDataGridViewTextBoxColumn.HeaderText = "StatusDescription";
            statusDescriptionDataGridViewTextBoxColumn.Name = "statusDescriptionDataGridViewTextBoxColumn";
            // 
            // orderViewModelBindingSource
            // 
            orderViewModelBindingSource.DataSource = typeof(DTO.Viewmodel.OrderViewModel);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(230, 30);
            label2.TabIndex = 3;
            label2.Text = "Đơn hàng hoàn thành :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(237, 108);
            label3.Name = "label3";
            label3.Size = new Size(24, 30);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(932, 108);
            label4.Name = "label4";
            label4.Size = new Size(24, 30);
            label4.TabIndex = 6;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(780, 108);
            label5.Name = "label5";
            label5.Size = new Size(157, 30);
            label5.TabIndex = 5;
            label5.Text = "Đơn hàng hủy :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(514, 108);
            label1.Name = "label1";
            label1.Size = new Size(24, 30);
            label1.TabIndex = 8;
            label1.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(385, 108);
            label6.Name = "label6";
            label6.Size = new Size(123, 30);
            label6.TabIndex = 7;
            label6.Text = "Doanh thu :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(116, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(212, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 41);
            label7.Name = "label7";
            label7.Size = new Size(98, 30);
            label7.TabIndex = 10;
            label7.Text = "Từ ngày :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(392, 41);
            label8.Name = "label8";
            label8.Size = new Size(113, 30);
            label8.TabIndex = 12;
            label8.Text = "Đến ngày :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(511, 48);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(212, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(763, 46);
            button1.Name = "button1";
            button1.Size = new Size(97, 30);
            button1.TabIndex = 13;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 625);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(dateTimePicker2);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orders";
            Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderViewModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createDayDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDescriptionDataGridViewTextBoxColumn;
        private BindingSource orderViewModelBindingSource;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private PageSetupDialog pageSetupDialog1;
    }
}