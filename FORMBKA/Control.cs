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

    public partial class Control : Form
    {
        public string UserLogin { get; set; }
        public bool isChange = false;
        public Control()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void standardControl1_Load(object sender, EventArgs e)
        {

        }

        private void Control_Load(object sender, EventArgs e)
        {
            int rs = Int32.Parse(UserLogin);
            if(rs ==0)
            {

                lbUserLogin.Text = "admin";
            }else
            {
                lbUserLogin.Text = "operator";
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isChange = true;
            pgColor1.Text = "111";
            //changeColor();


        }

        void changeColor()
        {
            if(pgColor1.BackColor == Color.Green)
            {
                pgColor1.BackColor = Color.Yellow;
            }else
            {
                pgColor1.BackColor = Color.Green;
            }


            if (pgColor2.BackColor == Color.Yellow)
            {
                pgColor2.BackColor = Color.Green;
            }
            else
            {
                pgColor1.BackColor = Color.Yellow;
            }

            changeColor();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
