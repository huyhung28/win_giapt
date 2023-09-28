using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_giapt
{
    public partial class hung : Form
    {
        public hung()
        {
            InitializeComponent();
        }

        private void ketqua_Click(object sender, EventArgs e)
        {
            int a =Convert.ToInt16(textBox1.Text);
            int b=Convert.ToInt16(textBox2.Text);
            int c= Convert.ToInt16(textBox3.Text);
            double delta=0;
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                textBox4.Text = Convert.ToString(" nghiem thu 1:  " + x1 + "    nghiem thu 2:  " + x2);

            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
              textBox4.Text = Convert.ToString(" nghiem kep: " + x);
            }
            else
            {
                textBox4.Text = "Phương trình không có nghiệm thực.";
            }

        }

        private void tb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok day la thong bao!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
