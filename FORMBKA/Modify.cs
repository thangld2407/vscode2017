using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FORMBKA
{
    class Modify
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        public Modify()
        {

        }

        public List<Account> Accounts(string query)
        {
            List<Account> accounts = new List<Account>();

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                sqlCommand = new SqlCommand();

                sqlCommand.Connection = conn;
                sqlCommand.CommandText = query;
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    var username = dataReader.GetValue(1);
                    var password = dataReader.GetValue(2);
                    var role = dataReader.GetValue(3);

                    accounts.Add(new Account(username.ToString(), password.ToString(), Int32.Parse(role.ToString())));
                }

               
            }

            return accounts;
        }

        public string getRole(string query)
        {
            string role = "";

            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                sqlCommand = new SqlCommand();

                sqlCommand.Connection = conn;
                sqlCommand.CommandText = query;
                dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                   role = dataReader.GetValue(3).ToString();
                }
            }

            return role;


        }



    }

}

