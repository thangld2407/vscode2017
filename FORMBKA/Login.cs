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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Modify modify = new Modify();
            try { 
            
                if (username.Trim() == "" || password.Trim() == "")
                {
                    MessageBox.Show("Missing some field");
                    return;
                }
                else
                {
                    string query = "SELECT * FROM Account WHERE username = '"+username+"' " ;

                    var account = modify.Accounts(query);
                    if (account.Count > 0)
                    {
                        MessageBox.Show("Login Success");
                        this.Hide();
                        var formControl = new Control();
                        formControl.UserLogin = modify.getRole(query);
                        formControl.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
        

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
