﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace FORMBKA
{
    class Connection
    {
        private static string connectionString = @"Data Source=CATPC\SQLEXPRESS;Initial Catalog=formpk;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
