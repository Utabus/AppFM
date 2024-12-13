using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPFM
{
    public partial class Orders : Form
    {
        OrdersBUS bus = new OrdersBUS();
        public Orders()
        {
            InitializeComponent();

            var orderDay = bus.Order(null, null);
            dataGridView1.DataSource = orderDay;
            label3.Text = orderDay.Where(x => x.StatusDescription == "Hoàn thành").Count().ToString();
            label1.Text = orderDay
      .Where(x => x.StatusDescription == "Hoàn thành")
      .Sum(x => x.Total ?? 0)
      .ToString("C0", new CultureInfo("vi-VN"));

            label4.Text = orderDay.Where(x => x.StatusDescription == "Đơn hủy").Count().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var orderDay = bus.Order(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView1.DataSource = orderDay;
            label3.Text = orderDay.Where(x => x.StatusDescription == "Hoàn thành").Count().ToString();
            label1.Text = orderDay
      .Where(x => x.StatusDescription == "Hoàn thành")
      .Sum(x => x.Total ?? 0)
      .ToString("C0", new CultureInfo("vi-VN"));

            label4.Text = orderDay.Where(x => x.StatusDescription == "Đơn hủy").Count().ToString();
        }
    }
}
