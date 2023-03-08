using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMBKA
{
    public partial class ChangePw : Form
    {
        public string UserLogin { get; set; }
        public ChangePw()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();
            
            if(txtNewPassword.Text != txtConfirmPw.Text)
            {
                MessageBox.Show("Mat khau khong khop");
                return;
            }

            modify.changePassword(UserLogin, txtNewPassword.Text);

            MessageBox.Show("Change Password success");
            this.Close();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
