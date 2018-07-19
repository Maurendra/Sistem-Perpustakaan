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
    public partial class AdminForm : Form
    {
        MySqlConnection koneksi;
        MySqlCommand query;
        DataSet ds;
        string id, fullname, address, phone;
        MySqlDataAdapter dt;
        public AdminForm()
        {
            InitializeComponent();
            string data = "server=localhost; uid=root; pwd=; database=projectppkprauts";
            koneksi = new MySqlConnection(data);
            bacaDataMember();
            bacaDataRent();
        }

        private void bacaDataMember()
        {
            try
            {
                ds = new DataSet();
                koneksi.Open();
                query = new MySqlCommand();
                query.Connection = koneksi;
                query.CommandType = CommandType.Text;
                query.CommandText = "select * from member";
                dt = new MySqlDataAdapter(query);
                dt.Fill(ds, "sub_daftar");
                dgvMemberList.DataSource = ds;
                dgvMemberList.DataMember = "sub_daftar";
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            MemberForm mbform = new MemberForm();

            if (mbform.ShowDialog() == DialogResult.OK)
            {
                bacaDataMember();
            }
        }

        private void btnAddRent_Click(object sender, EventArgs e)
        {
            if (dgvMemberList.CurrentRow != null)
            {
                string selectedID = (string)dgvMemberList.CurrentRow.Cells[0].Value;
                string selectedName = dgvMemberList.CurrentRow.Cells[1].Value.ToString();
                RentForm form = new RentForm(selectedID);
                form.ShowDialog();
            }
            bacaDataRent();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvRent.CurrentRow == null)
            {
                if (dgvMemberList.CurrentRow != null)
                {
                    try
                    {
                        koneksi.Open();
                        query = new MySqlCommand();
                        query.Connection = koneksi;
                        query.CommandType = CommandType.Text;
                        query.CommandText = "delete from member where member_id = '" + id + "'";
                        query.ExecuteNonQuery();
                        MessageBox.Show("Data berhasil dihapus");
                        koneksi.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    bacaDataMember();
                }
            }
            else
            {
                MessageBox.Show("Peminjaman masih ada, member tidak bisa dihapus");
            }
            
        }

        private void dgvMemberList_SelectionChanged(object sender, EventArgs e)
        {
            bacaDataRent();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            ManageItemsForm mngbookitem = new ManageItemsForm();
            mngbookitem.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvRent.CurrentRow != null) {
                int selisihTanggal = Convert.ToInt32(dgvRent.CurrentRow.Cells[5].Value);
                int denda = 0;
                if (selisihTanggal > 0) {
                    denda = selisihTanggal * 500;
                }
                if (MessageBox.Show("Buku telah dikembalikan\n\n Denda : Rp " + denda,
                    "Pengembalian", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        koneksi.Open();
                        query = new MySqlCommand();
                        query.Connection = koneksi;
                        query.CommandType = CommandType.Text;
                        query.CommandText = "delete from rent where member_id = '" 
                            + dgvRent.CurrentRow.Cells[0].Value + "' AND book_id='"+ dgvRent.CurrentRow.Cells[1].Value + "'";
                        query.ExecuteNonQuery();
                        koneksi.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex);
                    }
                    bacaDataRent();
                }
            }
        }
        
        private void dgvMemberList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvMemberList.Rows[e.RowIndex].Cells[0].Value.ToString();
            fullname = dgvMemberList.Rows[e.RowIndex].Cells[1].Value.ToString();
            address = dgvMemberList.Rows[e.RowIndex].Cells[2].Value.ToString();
            phone = dgvMemberList.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            MemberForm mbform = new MemberForm(id, fullname, address, phone, "Edit");

            if (mbform.ShowDialog() == DialogResult.OK)
            {
                bacaDataMember();
            }
        }

        private void bacaDataRent()
        {
            if (dgvMemberList.CurrentRow != null)
            {
                string selected_id = (string)dgvMemberList.CurrentRow.Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                string sql = "select a.member_id, c.book_id as ID, c.tittle as Judul, a.waktu_peminjaman as Pinjam " +
                    ", a.waktu_pengembalian as Pengembalian," +
                    " datediff('2017-11-30', waktu_pengembalian) as selisih from rent as a " +
                    "JOIN books as c " +
                    "on a.book_id=c.book_id " +
                    "where a.member_id=" + selected_id;
                try
                {
                    koneksi.Open();
                    query = new MySqlCommand(sql, koneksi);
                    MySqlDataAdapter adp = new MySqlDataAdapter(query);
                    query.ExecuteNonQuery();
                    adp.Fill(dt);
                    dgvRent.DataSource = dt;
                    dgvRent.Columns[0].Visible = false;
                    dgvRent.Columns[5].Visible = false;
                }
                catch (Exception ali)
                {
                    MessageBox.Show(ali.Message);
                }
                koneksi.Close();
            }
        }
    }
}
