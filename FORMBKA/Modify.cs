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
                    accounts.Add(new Account(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3)));
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
                   role = dataReader.GetString(3);
                }
            }

            return role;


        }



    }

}

