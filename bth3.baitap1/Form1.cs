using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bth3.baitap1
{
    public partial class Giaiphuongtrinhbacnhat : Form
    {
        public Giaiphuongtrinhbacnhat()
        {
            InitializeComponent();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtnghiem.Clear();
            btnxoa.Enabled = false;
            btngiai.Enabled = false;
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                errorProvider1.SetError(txta, "Hãy nhập a!");
                btngiai.Enabled = false;
                btnxoa. Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                if (txtb.Text == "")
                {
                    btngiai.Enabled = true;
                    btnxoa. Enabled = true;
                }
            }
        }

        private void txtb_TextChanged(object sender, EventArgs e)
        {
            if (txtb.Text == "")
            {
                errorProvider2.SetError(txtb, "Hãy nhập b!");
               btngiai.Enabled = false;
                btnxoa.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                if (txta.Text == "")
                {
                    btngiai.Enabled = true;
                    btnxoa. Enabled = true;
                }
            }
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
           double a = Convert.ToSingle(txta.Text);
           double b = Convert.ToSingle(txtb.Text);
            if(a == 0)
            {
                if (b== 0)
                {
                    txtnghiem.Text = "Phương trình vô số nghiệm";

                }
                else
                {
                    txtnghiem.Text = "Phương trình vô nghiệm";
                }
            } else
            {
                double x = -b / a;
                txtnghiem.Text = "Phương trình có nghiệm duy nhất là: " + x;
                btngiai.Enabled = false;
                btnxoa.Enabled = false;
            }
        }

        private void Giaiphuongtrinhbacnhat_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát ?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
