using BUS;
using DTO;
using DTO.Viewmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPFM
{
    public partial class Shop : Form
    {
        private ShopBUS shopBUS = new ShopBUS();
        private BindingList<CheckOutViewModel> checkOutViewModels = new BindingList<CheckOutViewModel>();
        public Shop()
        {
            InitializeComponent();

            //string relativePath = @$"..\..\..\..\..\WebFM_Style\WebFM_Style\Uploads\Images\Product\32132s1.jpg";  // Đi lên một cấp và vào thư mục Images
            //string absolutePath = Path.GetFullPath(relativePath);
            //pictureBox1.Image = System.Drawing.Image.FromFile(absolutePath);
            dataGridView1.DataSource = shopBUS.GetProducts("");


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// timkiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = shopBUS.GetProducts(textBox4.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấp vào một ô trong dòng (không phải trên header)
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                var column1Data = selectedRow.Cells[0].Value;

                if (column1Data != null && int.TryParse(column1Data.ToString(), out int productId))
                {
                    var product = shopBUS.GetProduct(productId);
                    textBox1.Text = product.Name;
                    textBox2.Text = string.Format(new CultureInfo("vi-VN"), "{0:C0}", product.Price);
                    textBox3.Text = "1";
                    textBox5.Text = $"{productId}";



                    // Xóa các item cũ trong comboBox trước khi thêm các item mới
                    comboBox2.Items.Clear();
                    comboBox1.Items.Clear();

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();  // Giải phóng ảnh cũ
                        pictureBox1.Image = null;     // Đặt lại ảnh cũ thành null
                    }
                    string relativePath = @$"..\..\..\..\..\WebFM_Style\WebFM_Style\Uploads\Images\Product\{product.Images.FirstOrDefault().Url}";  // Đi lên một cấp và vào thư mục Images
                    string absolutePath = Path.GetFullPath(relativePath);
                    pictureBox1.Image = System.Drawing.Image.FromFile(absolutePath);
                    // Duyệt qua tất cả ProductSizeColors và lấy Size1
                    foreach (var productSizeColor in product.ProductSizeColors)
                    {
                        // Kiểm tra null trước khi thêm vào ComboBox
                        if (productSizeColor.Size != null && productSizeColor.Size.Size1 != null)
                        {
                            comboBox2.Items.Add(productSizeColor.Size.Size1);
                        }
                        if (productSizeColor.Color != null && productSizeColor.Color.Color1 != null)
                        {
                            comboBox1.Items.Add(productSizeColor.Color.Color1);
                        }

                    }

                    // (Tùy chọn) Chọn item đầu tiên trong ComboBox nếu có
                    if (comboBox2.Items.Count > 0)
                    {
                        comboBox2.SelectedIndex = 0;
                    }
                    if (comboBox1.Items.Count > 0)
                    {
                        comboBox1.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid product ID.");
                }

            }
        }
        /// <summary>
        /// them 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }

            var checkout = new CheckOutViewModel
            {
                Id = int.Parse(textBox5.Text),
                Quantity = int.Parse(textBox3.Text),
                Price = textBox2.Text,
                Size = comboBox2.Text,
                Color = comboBox1.Text,
                Name = textBox1.Text,
            };
            var checkEx = checkOutViewModels.FirstOrDefault(x => x.Name == checkout.Name && x.Color == checkout.Color && x.Size == checkout.Size);
            if (checkEx != null)
            {
                checkEx.Quantity += checkout.Quantity;
            }
            else
            {
                checkOutViewModels.Add(checkout);
            }
            label11.Text = $"{checkOutViewModels.Sum(x => x.Quantity)}";
            label10.Text = String.Format(new CultureInfo("vi-VN"), "{0:C0}",
       checkOutViewModels.Sum(x => decimal.Parse(x.Price.Replace(".", "").Replace("₫", "").Trim()) * x.Quantity));

            dataGridView2.DataSource = checkOutViewModels;
        }


        /// <summary>
        /// /xoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            checkOutViewModels = new BindingList<CheckOutViewModel>();
            dataGridView2.DataSource = checkOutViewModels;
            label11.Text = "0";
            label10.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (shopBUS.CheckOut(checkOutViewModels.ToList() , GlobalVariables.Id))
            {
                checkOutViewModels = new BindingList<CheckOutViewModel>();
                dataGridView2.DataSource = checkOutViewModels;
                label11.Text = "0";
                label10.Text = "0";
                MessageBox.Show("Đặt hàng thành công ");
            }
            else
            {
                MessageBox.Show("Đặt hàng thất bại");
            }
        }
    }
}
