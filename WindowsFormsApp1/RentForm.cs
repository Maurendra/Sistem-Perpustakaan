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
    public partial class RentForm : Form
    {
        MySqlConnection koneksi;
        MySqlCommand query;
        DataSet ds;
        MySqlDataAdapter adp;
        string member_id;
        private string waktu_sekarang;
        private string waktu_batas_pengembalian;
        public RentForm()
        {
            InitializeComponent();
            string data = "server=localhost; uid=root; pwd=; database=projectppkprauts";
            koneksi = new MySqlConnection(data);
            bacaListBuku();
            bacaRent();
        }

        public RentForm(string member_id)
        {
            InitializeComponent();
            string data = "server=localhost; uid=root; pwd=; database=projectppkprauts";
            koneksi = new MySqlConnection(data);
            bacaListBuku();
            this.member_id = member_id;
            bacaRent();
        }

        public DataTable bacaListBuku()
        {
            string sql = "Select book_id as book_id, tittle as Nama from books";
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                adp.Fill(dt);
                itemdatagrid.DataSource = dt;
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            koneksi.Close();
            return (dt);
        }

        public DataTable bacaRent()
        {
            string sql = "Select mn.book_id as Kode, mn.tittle as Nama from books as mn join " +
                "buffer_rent as mb on mb.book_id=mn.book_id where mb.member_id = " + this.member_id;
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
                adp.Fill(dt);
                rentdatagrid.DataSource = dt;
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            koneksi.Close();
            return (dt);
        }

        public void insertRent(string book_id)
        {
            string sql = "INSERT INTO buffer_rent VALUES ('" + this.member_id + "','" + book_id + "', '"+this.waktu_sekarang+ "', '" + this.waktu_batas_pengembalian+ "')";
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            koneksi.Close();
        }

        public void deleteBook(string book_id)
        {
            string sql = "DELETE from buffer_rent WHERE member_id = '" + this.member_id.ToString() + "' and book_id = '" + book_id.ToString()+"'";
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = new MySqlCommand(sql, koneksi);
                adp = new MySqlDataAdapter(query);
                query.ExecuteNonQuery();
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            koneksi.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (itemdatagrid.CurrentRow != null)
            {
                string selectedItemID = itemdatagrid.CurrentRow.Cells[0].Value.ToString();
                insertRent(selectedItemID);
                bacaRent();
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (rentdatagrid.CurrentRow != null)
            {
                    string selectedItemID = rentdatagrid.CurrentRow.Cells[0].Value.ToString();
                    deleteBook(selectedItemID);
                    bacaRent();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (rentdatagrid.CurrentRow != null) {
                if (MessageBox.Show("Apakah yakin ingin keluar?", "Peminjaman", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "delete from notes_review";
                    try
                    {
                        query = new MySqlCommand(sql, koneksi);
                        adp = new MySqlDataAdapter(query);
                        query.ExecuteNonQuery();
                    }
                    catch (Exception ali)
                    {
                        MessageBox.Show(ali.Message);
                    }
                    koneksi.Close();
                }
            }
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (rentdatagrid.CurrentRow != null) {
                if (MessageBox.Show("Apakah sudah semua peminjaman?", "Peminjaman", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sql = "insert into rent (select * from buffer_rent)";
                    try
                    {
                        koneksi.Open();
                        query = new MySqlCommand(sql, koneksi);
                        adp = new MySqlDataAdapter(query);
                        query.ExecuteNonQuery();
                        sql = "delete from buffer_rent";
                        query = new MySqlCommand(sql, koneksi);
                        adp = new MySqlDataAdapter(query);
                        query.ExecuteNonQuery();
                    }
                    catch (Exception ali)
                    {
                        MessageBox.Show(ali.Message);
                    }
                    koneksi.Close();
                    bacaRent();
                }
                
            }
        }

        private void timerFungtion_Tick(object sender, EventArgs e)
        {
            DateTime waktu_batas;
            DateTime waktu = DateTime.Now;
            this.waktu_sekarang = waktu.ToString("yyyy-MM-dd");
            waktu_batas = waktu.AddDays(Convert.ToInt16("7"));
            this.waktu_batas_pengembalian = waktu_batas.ToString("yyyy-MM-dd");
        }
    }
}
