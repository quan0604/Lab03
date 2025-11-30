using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu rỗng
            if (string.IsNullOrWhiteSpace(txtLast.Text) ||
                string.IsNullOrWhiteSpace(txtFirst.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Tạo dòng mới
            ListViewItem item = new ListViewItem(txtLast.Text);
            item.SubItems.Add(txtFirst.Text);
            item.SubItems.Add(txtPhone.Text);

            // Thêm vào ListView
            lstSV.Items.Add(item);

            // Reset textbox
            txtLast.Clear();
            txtFirst.Clear();
            txtPhone.Clear();
            txtLast.Focus();
        }

        private void lstSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSV.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstSV.SelectedItems[0];

            txtLast.Text = item.SubItems[0].Text;     
            txtFirst.Text = item.SubItems[1].Text;    
            txtPhone.Text = item.SubItems[2].Text;
        }
    }
}
