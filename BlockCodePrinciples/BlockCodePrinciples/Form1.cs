using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlockCodePrinciples
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {     
        public Form1()
        {
            InitializeComponent();
        }    
        #region values
        codewords code = new codewords();
        List<codewords> lst;
        string values;
        int dem = 0;
        int minden;
        string minketqua;
        #endregion
        #region Method
        private void loadlst()
        {
            lst = new List<codewords>()
            {
                new codewords() {Name = "0000" },
                new codewords() {Name = "0001" },
                new codewords() {Name = "0010" },
                new codewords() {Name = "0011" },
                new codewords() {Name = "0100" },
                new codewords() {Name = "0101" },
                new codewords() {Name = "0110" },
                new codewords() {Name = "0111" },
                new codewords() {Name = "1000" },
                new codewords() {Name = "1001" },
                new codewords() {Name = "1010" },
                new codewords() {Name = "1011" },
                new codewords() {Name = "1100" },
                new codewords() {Name = "1101" },
                new codewords() {Name = "1110" },
                new codewords() {Name = "1111" },
            };
        }
        private void loadForm()
        {
            loadlst();
            foreach (codewords values in lst)
            {
                lsvCodewords.Items.Add(values.Name);
            }
            lsvCodewords.Items[0].Selected = true;
            lsvCodewords.Items[0].BackColor = Color.DarkOrange;
            lblQ.Text = "q = " + lsvCodewords.Items[0].Text;
            lblKQ.Text = "q = " + lsvCodewords.Items[0].Text;
            lblKQ.Text = "d (p , q) = ";
            lblKQQ.Text = "q = 0000000";
            lblD.Text = "d (p , q) = ";


        }
        private int demSoBit(string p, string q)
        {
            int dem = 0;
            for (int i = 0; i < p.Length; ++i)
            {
                if (p[i] != q[i])
                    dem++;
            }
            return dem;
        }
        private void randCodeWord()
        {

        }
        #endregion
        #region Events
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblP.Text = "p = " + tbxNhap.Text;
            lblKQP.Text = "p = " + tbxNhap.Text;
        }
        private void tbxNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbxNhap.Text.Length < 7)
            {
                if (e.KeyChar != '0' && !char.IsControl(e.KeyChar) && e.KeyChar != '1')
                {
                    e.Handled = true;

                }

            }
            else
            {
                if (!char.IsControl(e.KeyChar))
                {
                    MessageBox.Show("Độ dài của codewords không được lớn hơn 7.");
                    e.Handled = true;
                }
            }
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (tbxNhap.Text.Length == 7)
            {
                minden = demSoBit(tbxNhap.Text, lsvCodewords.Items[0].Text);
                lblP.Text = "p = " + tbxNhap.Text;
                lblKQP.Text = "p = " + tbxNhap.Text;
                lblD.Text = "d(p, q) = " + demSoBit(tbxNhap.Text, values);
                lblKQ.Text = "d(p, q) = " + demSoBit(tbxNhap.Text, values);
                btnNhapLai.Enabled = true;
                btnNhap.Enabled = false;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Bạn cần phải nhập đúng codewords.");
            }
        }
        private void lsvCodewords_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lvs = sender as ListView;
            
            if (lvs.SelectedItems.Count > 0)
            {
                lsvCodewords.Items[dem].BackColor = Color.DarkOrange;
                ListViewItem item = lvs.SelectedItems[lvs.SelectedItems.Count - 1];
                values = item.Text;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dem < 16)
            {
                lsvCodewords.Items[dem].BackColor = Color.DarkOrange;
                lsvCodewords.Items[dem].Selected = true;
                lblQ.Text = "q = " + lsvCodewords.Items[dem].Text;
                lblD.Text = "d(p, q) = " + demSoBit(tbxNhap.Text, values);
                if (minden > demSoBit(tbxNhap.Text, values))
                {
                    minden = demSoBit(tbxNhap.Text, values);
                    minketqua = values;
                    lblKQQ.Text = "q = " + minketqua;
                    lblKQ.Text = "d(p, q) = " + demSoBit(tbxNhap.Text, minketqua);
                }
                dem++;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Kết quả 'Block Code Principles' của " + tbxNhap.Text + " là " + minketqua + ", và 'Hamming distance = '" + minden);
            }
        }
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            tbxNhap.Clear();
            lsvCodewords.Clear();
            btnNhap.Enabled = true;
            btnNhapLai.Enabled = false;
            dem = 0;
            loadForm();
        }
        #endregion  

    }
}
