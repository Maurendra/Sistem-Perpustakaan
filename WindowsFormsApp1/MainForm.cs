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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bacaDataSearch();
        }

        private void bacaDataSearch()
        {
            string data = "server=localhost; uid=root; pwd=; database=projectppkprauts";
            MySqlConnection connect = new MySqlConnection(data);
            MySqlCommand query;
            DataSet ds;

            try
            {
                ds = new DataSet();
                connect.Open();
                query = new MySqlCommand();
                query.Connection = connect;
                query.CommandType = CommandType.Text;

                if (tbJudulBuku.Text != string.Empty && tbPengarangBuku.Text != string.Empty && tbPenerbitBuku.Text != string.Empty && cbKategoriBuku.Text != string.Empty)
                {
                    query.CommandText = "select * from books where tittle like '%" + tbJudulBuku.Text + "%' and author like '%" + tbPengarangBuku.Text + "%' and publisher like '%" + tbPenerbitBuku.Text + "%' and category like '%" + cbKategoriBuku.SelectedItem.ToString() + "%'";
                }
                else
                {
                    if (tbJudulBuku.Text != string.Empty)
                    {
                        query.CommandText = "select * from books where tittle like '%" + tbJudulBuku.Text + "%';";
                    }

                    else if (tbPengarangBuku.Text != string.Empty)
                    {
                        query.CommandText = "select * from books where author like '%" + tbPengarangBuku.Text + "%';";
                    }

                    else if (tbPenerbitBuku.Text != string.Empty)
                    {
                        query.CommandText = "select * from books where publisher like '%" + tbPenerbitBuku.Text + "%';";
                    }

                    else if (cbKategoriBuku.Text != string.Empty)
                    {
                        query.CommandText = "select * from books where category like '%" + cbKategoriBuku.Text + "%';";
                    }
                }
                
                // query.CommandText = "select * from books where tittle like '%"+ tbJudulBuku.Text +"%' or author like '%"+ tbPengarangBuku.Text +"%' or publisher like '%"+ tbPenerbitBuku.Text +"%' or category like '%"+ cbKategoriBuku.SelectedItem.ToString() +"%'";
                MySqlDataAdapter dt = new MySqlDataAdapter(query);
                dt.Fill(ds, "sub_daftar");
                dgvDataBuku.DataSource = ds;
                dgvDataBuku.DataMember = "sub_daftar";
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

        }

        public void refresh()
        {

        }
    }
}
