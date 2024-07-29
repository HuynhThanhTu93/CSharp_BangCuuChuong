using System;

namespace CSharp_BangCuuChuong
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
        }
        private void LayThongTin()
        {
            try
            {
                n = Convert.ToInt32(txtSo.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo.Clear();
            }
        }
        private void HienThiKQ()
        {
            LayThongTin();
            lblKQ.Text = "";
            listB1.Items.Clear();
            comB1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                lblKQ.Text += Environment.NewLine + n.ToString() + " x " + i.ToString() + " = " + (n * i);
                listB1.Items.Add(n.ToString() + " x " + i.ToString() + " = " + (n * i));
                comB1.Items.Add(n.ToString() + " x " + i.ToString() + " = " + (n * i));
            }

        }
        private void KiemTraRDO(object sender, EventArgs e)
        {
            lblKQ.Text = "";
            listB1.Items.Clear();
            comB1.Items.Clear();
            RadioButton r = (RadioButton)sender;
            int n = Convert.ToInt32(r.Text);
            for (int i = 1; i <= 10; i++)
            {
                lblKQ.Text += Environment.NewLine + n.ToString() + " x " + i.ToString() + " = " + (n * i);
                listB1.Items.Add(n.ToString() + " x " + i.ToString() + " = " + (n * i));
                comB1.Items.Add(n.ToString() + " x " + i.ToString() + " = " + (n * i));
            }
        }


        private void btnBox_Click(object sender, EventArgs e)
        {
            HienThiKQ();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            txtSo.Text = numericUpDown1.Value.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtSo.Text = lblSo.Text = trackBar1.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HienThiKQ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LayThongTin();
            if (rdo2.Checked)
            {
                int n = 2;
                HienThiKQ();
            }
        }
    }
}
