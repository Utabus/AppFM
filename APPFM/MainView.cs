using DTO;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace APPFM
{
    public partial class MainView : Form
    {
        private List<Button> _buttons;
      
        public MainView(DTO.Account account)
        {
            InitializeComponent();
            _buttons = new List<Button> { btnTrangchu, btnThoat, btnBanhang, btnKho, btnDonHang };
            label1.Text = account.FullName;
            textBox1.Text = account.Id.ToString();
            GlobalVariables.Id = account.Id;
            OpenChildForm(new Home());
        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_NoiDung.Controls.Add(ChildForm);
            panel_NoiDung.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();

        }
        private void HighlightButton(Button activeButton)
        {
            if (activeButton.BackColor == System.Drawing.Color.LightBlue)
            {
                activeButton.BackColor = System.Drawing.Color.LightGray;
                return;
            }

            foreach (var button in _buttons)
            {
                button.BackColor = Color.White;
            }

            activeButton.BackColor = Color.LightBlue;
        }


        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Trang chủ";
            HighlightButton(btnTrangchu); // Đổi màu nút
            OpenChildForm(new Home());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Trang chủ";
            HighlightButton(btnThoat); // Đổi màu nút
            Application.Exit();
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Bán hàng";
            HighlightButton(btnBanhang); // Đổi màu nút
            OpenChildForm(new Shop());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Kho hàng";
            HighlightButton(btnKho); // Đổi màu nút
            OpenChildForm(new Warehourse());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Đơn hàng";
            HighlightButton(btnDonHang); // Đổi màu nút
            OpenChildForm(new Orders());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = null;
            textBox1.Text = null;
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public static class GlobalVariables
    {
        public static int Id { get; set; }
    }

}
