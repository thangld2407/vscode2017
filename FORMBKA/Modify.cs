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


        public void changePassword(string username, string newPassword)
        {
            string query = "UPDATE Account SET password = '"+newPassword+"' WHERE username = '" +username+"'";
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                sqlCommand = new SqlCommand();

                sqlCommand.Connection = conn;
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteReader();

                
            }
            return;
        }

        public RecipeObj getRecipeDefault()
        {
            string query = "SELECT * FROM Recipe WHERE isDefault = '0'";
            RecipeObj recipeObj = new RecipeObj();


            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();

                sqlCommand = new SqlCommand();

                sqlCommand.Connection = conn;
                sqlCommand.CommandText = query;
                dataReader = sqlCommand.ExecuteReader();
                
                while (dataReader.Read())
                {
                    recipeObj.totalKhoiLuong =Int32.Parse(dataReader.GetValue(1).ToString());
                    recipeObj.xiMang =Int32.Parse(dataReader.GetValue(2).ToString());
                    recipeObj.cat =Int32.Parse(dataReader.GetValue(3).ToString());
                    recipeObj.troBay =Int32.Parse(dataReader.GetValue(4).ToString());
                    recipeObj.khoang =Int32.Parse(dataReader.GetValue(5).ToString());
                    recipeObj.pg1 =Int32.Parse(dataReader.GetValue(6).ToString());
                    recipeObj.pg2 =Int32.Parse(dataReader.GetValue(7).ToString());
                    recipeObj.pg3 =Int32.Parse(dataReader.GetValue(7).ToString());
                }
            }

            return recipeObj;


        }



    }

}

