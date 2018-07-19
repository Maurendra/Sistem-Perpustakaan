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
    public partial class MemberForm : Form
    {
        MySqlConnection connect;
        public MemberForm()
        {
            InitializeComponent();
            string connectionInfo = "datasource=localhost;username=root;password=;database=projectppkprauts;";
            connect = new MySqlConnection(connectionInfo);
        }

        public MemberForm(string id, string fullname, string address, string phone, string jenis)
        {
            InitializeComponent();
            string connectionInfo = "datasource=localhost;username=root;password=;database=projectppkprauts;";
            connect = new MySqlConnection(connectionInfo);
            tbKodeMember.Text = id;
            tbFullnameMember.Text = fullname;
            tbAddressMember.Text = address;
            tbPhoneMember.Text = phone;
            btnAddMember.Text = jenis;
            if (jenis == "Edit")
            {
                tbKodeMember.Enabled = false;
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (btnAddMember.Text.ToString()=="Add")
            {
                try
                {
                    string query = "insert into member values ('" + tbKodeMember.Text + "','" + tbFullnameMember.Text + "','" + tbAddressMember.Text + "','" + tbPhoneMember.Text + "');";
                    MySqlDataReader read;
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    read = cmd.ExecuteReader();
                    MessageBox.Show("Member berhasil ditambahkan");
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else if(btnAddMember.Text.ToString() == "Edit")
            {
                try
                {
                    string query = "update member set fullname = '"+ tbFullnameMember.Text +"', address = '"+ tbAddressMember.Text +"', phone_number = '"+ tbPhoneMember.Text +"' where member_id = '"+ tbKodeMember.Text +"'";
                    MySqlDataReader read;
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    read = cmd.ExecuteReader();
                    MessageBox.Show("Member berhasil dirubah");
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

