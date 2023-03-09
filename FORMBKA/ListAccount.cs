using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FORMBKA
{
    public partial class ListAccount : Form
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        public ListAccount()
        {
            InitializeComponent();
        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListAccount_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            string username = txtNewAccount.Text;
            string password = txtAddNewPassword.Text;
          
            if(username =="")
            {
                MessageBox.Show("Vui lòngg nhập tên tài khoản");
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Vui lòngg nhập mật khẩu");
                return;
            }

            if (txtRole.Text == "")
            {
                MessageBox.Show("Vui lòngg nhập vai trò");
                return;
            }

            int role = Int32.Parse(txtRole.Text);



            string query = "INSERT INTO ACCOUNT VALUES('123', '" + username + "'," + "'" + password + "'," + "'" + role + "')";


            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                sqlCommand = new SqlCommand();

       
                sqlCommand.Connection = conn;
                sqlCommand.CommandText = query;
                 sqlCommand.ExecuteReader();
            }

            MessageBox.Show("Add new account success");
            txtNewAccount.Text = "";
            txtAddNewPassword.Text = "";
            txtRole.Text = "";

            loadData();

        }

        void loadData()
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                sqlCommand = new SqlCommand();

                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Account", conn);

                DataTable dtbl = new DataTable();

                sqlData.Fill(dtbl);

                dgvAccount.DataSource = dtbl;

            }
        }
    }
}
