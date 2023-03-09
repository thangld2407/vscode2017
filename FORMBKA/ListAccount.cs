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
