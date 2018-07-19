using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class ManageItemsForm : Form
    {
        MySqlConnection koneksi;
        MySqlCommand query;
        DataSet ds;
        string book_id, title, author, publisher, category;

        

        private void btnAddBuku_Click(object sender, EventArgs e)
        {
            ItemForm mbform = new ItemForm();

            if (mbform.ShowDialog() == DialogResult.OK)
            {
                bacaDataBuku();
            }
        }

        private void dgvListBuku_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            book_id = dgvListBuku.Rows[e.RowIndex].Cells[0].Value.ToString();
            title = dgvListBuku.Rows[e.RowIndex].Cells[1].Value.ToString();
            author = dgvListBuku.Rows[e.RowIndex].Cells[2].Value.ToString();
            publisher = dgvListBuku.Rows[e.RowIndex].Cells[3].Value.ToString();
            category = dgvListBuku.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnDeleteBuku_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = new MySqlCommand();
                query.Connection = koneksi;
                query.CommandType = CommandType.Text;
                query.CommandText = "delete from books where book_id = '" + book_id + "'";
                query.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            bacaDataBuku();
        }

        public ManageItemsForm()
        {
            InitializeComponent();
            string data = "server=localhost; uid=root; pwd=; database=projectppkprauts";
            koneksi = new MySqlConnection(data);
            bacaDataBuku();
        }

        private void bacaDataBuku()
        {
            try
            {
                ds = new DataSet();
                koneksi.Open();
                query = new MySqlCommand();
                query.Connection = koneksi;
                query.CommandType = CommandType.Text;
                query.CommandText = "select * from books";
                MySqlDataAdapter dt = new MySqlDataAdapter(query);
                dt.Fill(ds, "sub_daftar");
                dgvListBuku.DataSource = ds;
                dgvListBuku.DataMember = "sub_daftar";
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnEditBuku_Click(object sender, EventArgs e)
        {
            ItemForm mbform = new ItemForm(book_id, title, author, publisher, category, "Edit");

            if (mbform.ShowDialog() == DialogResult.OK)
            {
                bacaDataBuku();
            }
        }
    }
}
