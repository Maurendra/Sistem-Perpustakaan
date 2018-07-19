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
    public partial class ItemForm : Form
    {
        MySqlConnection connect;
        public ItemForm()
        {
            InitializeComponent();
            string connectionInfo = "datasource=localhost;username=root;password=;database=projectppkprauts;";
            connect = new MySqlConnection(connectionInfo);
        }

        public ItemForm(string book_id, string title, string author, string publisher, string category, string jenis)
        {
            InitializeComponent();
            string connectionInfo = "datasource=localhost;username=root;password=;database=projectppkprauts;";
            connect = new MySqlConnection(connectionInfo);
            tbKodeBuku.Text = book_id;
            tbJudul.Text = title;
            tbPengarang.Text = author;
            tbPenerbit.Text = publisher;
            cbKategori.Text = category;
            btnTambahBuku.Text = jenis;
            if (jenis == "Edit")
            {
                tbKodeBuku.Enabled = false;
            }
        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            if (btnTambahBuku.Text.ToString() == "Add")
            {
                try
                {
                    string query = "insert into books values ('" + tbKodeBuku.Text + "','" + tbJudul.Text + "','" + tbPengarang.Text + "','" + tbPenerbit.Text + "','" + cbKategori.Text + "');";
                    MySqlDataReader read;
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    read = cmd.ExecuteReader();
                    MessageBox.Show("Data berhasil ditambahkan");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else if (btnTambahBuku.Text.ToString() == "Edit")
            {
                try
                {
                    string query = "update books set tittle = '" + tbJudul.Text +"', author = '" + tbPengarang.Text + "', publisher = '" + tbPenerbit.Text + "', category = '"+ cbKategori.Text +"' where book_id = '"+ tbKodeBuku.Text +"'";
                    MySqlDataReader read;
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    read = cmd.ExecuteReader();
                    MessageBox.Show("Buku berhasil dirubah");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
