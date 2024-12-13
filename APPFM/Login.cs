using BUS;
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
    public partial class Login : Form
    {
        private UserBUS userBus = new UserBUS();
        public Login()
        {
            InitializeComponent(); textBox2.PasswordChar = '*'; // Thay thế văn bản bằng dấu *
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var user = userBus.Login(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                MainView mainView = new MainView(user);
                mainView.FormClosed += (s, args) => this.Close(); // Đóng form Login khi MainView đóng
                this.Hide(); // Ẩn form Login
                mainView.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
                return;
            }

        }
    }
}
