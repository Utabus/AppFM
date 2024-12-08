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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            collectionProductsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imagesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productSizeColorsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, productTypeIdDataGridViewTextBoxColumn, collectionProductsDataGridViewTextBoxColumn, imagesDataGridViewTextBoxColumn, productSizeColorsDataGridViewTextBoxColumn, productTypeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(-1, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(895, 484);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
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
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // productTypeIdDataGridViewTextBoxColumn
            // 
            productTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ProductTypeId";
            productTypeIdDataGridViewTextBoxColumn.HeaderText = "ProductTypeId";
            productTypeIdDataGridViewTextBoxColumn.Name = "productTypeIdDataGridViewTextBoxColumn";
            // 
            // collectionProductsDataGridViewTextBoxColumn
            // 
            collectionProductsDataGridViewTextBoxColumn.DataPropertyName = "CollectionProducts";
            collectionProductsDataGridViewTextBoxColumn.HeaderText = "CollectionProducts";
            collectionProductsDataGridViewTextBoxColumn.Name = "collectionProductsDataGridViewTextBoxColumn";
            // 
            // imagesDataGridViewTextBoxColumn
            // 
            imagesDataGridViewTextBoxColumn.DataPropertyName = "Images";
            imagesDataGridViewTextBoxColumn.HeaderText = "Images";
            imagesDataGridViewTextBoxColumn.Name = "imagesDataGridViewTextBoxColumn";
            // 
            // productSizeColorsDataGridViewTextBoxColumn
            // 
            productSizeColorsDataGridViewTextBoxColumn.DataPropertyName = "ProductSizeColors";
            productSizeColorsDataGridViewTextBoxColumn.HeaderText = "ProductSizeColors";
            productSizeColorsDataGridViewTextBoxColumn.Name = "productSizeColorsDataGridViewTextBoxColumn";
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            productTypeDataGridViewTextBoxColumn.HeaderText = "ProductType";
            productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn collectionProductsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productSizeColorsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}