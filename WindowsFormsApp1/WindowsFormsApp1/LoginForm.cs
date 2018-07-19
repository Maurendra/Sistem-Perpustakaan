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
    public partial class LoginForm : Form
    {
        MySqlConnection connect;
        public LoginForm()
        {
            InitializeComponent();
            string connectionInfo = "datasource=localhost;username=root;password=;database=projectppkprauts;";
            connect = new MySqlConnection(connectionInfo);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "select * from admin where username='"+tbUsername.Text+"' and password='"+tbPassword.Text+"';";
            MySqlDataReader read;
            connect.Open();
            MySqlCommand cmd = new MySqlCommand(query, connect);
            read = cmd.ExecuteReader();
            if (read.Read())
            {
                AdminForm frmAdmin = new AdminForm();
                frmAdmin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("login gagal");
            }
        }
    }
}
