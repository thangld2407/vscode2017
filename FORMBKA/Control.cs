using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolFactoryDotNet;

namespace FORMBKA
{

    public partial class Control : Form
    {
        public string UserLogin { get; set; }
        public bool isChange = false;
        public bool isCollapsed;
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
            controlPG1Van1.DiscreteValue1 = true;


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

        private void standardControl7_Load(object sender, EventArgs e)
        {

        }

        private void standardControl10_Load(object sender, EventArgs e)
        {

        }

        private void standardControl8_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelSettings.Height += 100;

                if (panelSettings.Size == panelSettings.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                panelSettings.Height -= 100;
                if (panelSettings.Size == panelSettings.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }
    }
}
