using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPFM
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
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

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Trang chủ";
            OpenChildForm(new Home());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Trang chủ";
            Application.Exit();
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Bán hàng";
            OpenChildForm(new Shop());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Kho hàng";
            OpenChildForm(new Warehourse());
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            lblHome.Text = "Đơn hàng";
            OpenChildForm(new Orders());
        }
    }
}
