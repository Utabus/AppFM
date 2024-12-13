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
    public partial class Warehourse : Form
    {
        private WarehourseBUS WarehourseBUS;
        public Warehourse()
        {
            InitializeComponent();
            WarehourseBUS = new WarehourseBUS();
            dataGridView1.DataSource = WarehourseBUS.Products("");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                dataGridView1.DataSource = WarehourseBUS.Products(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = WarehourseBUS.Products(textBox1.Text);
        }
    }
}
