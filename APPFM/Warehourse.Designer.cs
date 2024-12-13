namespace APPFM
{
    partial class Warehourse
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
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            codeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantitySoldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productViewmodelBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            productViewmodelBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewmodelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewmodelBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, codeDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, quantitySoldDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productViewmodelBindingSource;
            dataGridView1.Location = new Point(-1, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(895, 484);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            codeDataGridViewTextBoxColumn.HeaderText = "Code";
            codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
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
            // quantitySoldDataGridViewTextBoxColumn
            // 
            quantitySoldDataGridViewTextBoxColumn.DataPropertyName = "QuantitySold";
            quantitySoldDataGridViewTextBoxColumn.HeaderText = "QuantitySold";
            quantitySoldDataGridViewTextBoxColumn.Name = "quantitySoldDataGridViewTextBoxColumn";
            // 
            // productViewmodelBindingSource
            // 
            productViewmodelBindingSource.DataSource = typeof(DTO.Viewmodel.ProductViewmodel);
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DTO.Product);
            // 
            // button1
            // 
            button1.Location = new Point(402, 34);
            button1.Name = "button1";
            button1.Size = new Size(97, 39);
            button1.TabIndex = 1;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(142, 30);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(160, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 35);
            textBox1.TabIndex = 3;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // productViewmodelBindingSource1
            // 
            productViewmodelBindingSource1.DataSource = typeof(DTO.Viewmodel.ProductViewmodel);
            // 
            // Warehourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 573);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Warehourse";
            Text = "Warehourse";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productViewmodelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productViewmodelBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantitySoldDataGridViewTextBoxColumn;
        private BindingSource productViewmodelBindingSource;
        private BindingSource productViewmodelBindingSource1;
    }
}