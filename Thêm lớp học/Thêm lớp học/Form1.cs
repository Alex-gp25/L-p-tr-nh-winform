namespace Thêm_lớp_học
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtTen.Text)) || (string.IsNullOrEmpty(txtsoluong.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = txtTen.Text;
                listView1.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (txtsoluong.Text));
                item.SubItems.Add(subitem);

                txtTen.Clear();
                txtsoluong.Clear();
                txtTen.Focus();
            }
        }
    }
}