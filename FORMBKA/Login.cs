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

using System.Configuration;

namespace FORMBKA
{
    public partial class Login : Form
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM ACCOUNT";
            var taikhoans = new List<String>(); 
            try
            {
                using(SqlConnection conn = Connection.GetSqlConnection())
                {
                    conn.Open();

                    sqlCommand = new SqlCommand();

                    sqlCommand.Connection = conn;
                    sqlCommand.CommandText = query;
                    dataReader = sqlCommand.ExecuteReader();

                    while(dataReader.Read())
                    {
                        taikhoans.Add(dataReader.GetString(1));
                    }
                }

                query += " WHERE username=" + txtUsername.Text;

                //this.Hide();
                new Control().Show();

            }catch(Exception ex)
            {   
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
