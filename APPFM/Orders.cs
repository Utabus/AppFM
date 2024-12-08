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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            OrdersBUS bus = new OrdersBUS();
            dataGridView1.DataSource = bus.Order();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
