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
        public string username { get; set; }
        public bool isChange = false;
        public bool isChangeVan1 = false;
        public bool isChangeVan2 = false;
        public bool isChangeVan3 = false;
        public bool isChangeVan4 = false;
        public bool isChangeVan5 = false;
        public bool isChangeVan6 = false;

        public bool isChangeXimang = false;
        public bool isChangeCat = false;
        public bool isChangeTroBay = false;
        public bool isChangePhuGiaKhoang = false;


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

            Modify modify = new Modify();

            RecipeObj recipeObj = modify.getRecipeDefault();

            numberXimang.Value = recipeObj.xiMang;
            numberTroBay.Value = recipeObj.troBay;
            numberKhoang.Value = recipeObj.khoang;
            numberPhuGia1.Value = recipeObj.pg1;
            numberPhuGia2.Value = recipeObj.pg2;
            numberPhuGia3.Value = recipeObj.pg3;
            numberCat.Value = recipeObj.cat;


        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pgTotal.Text = (numberPhuGia1.Value + numberPhuGia2.Value + numberPhuGia3.Value).ToString();
            totalXiCat.Text = (numberXimang.Value + numberCat.Value).ToString();
            totalTroKhoang.Text = (numberTroBay.Value + numberKhoang.Value).ToString();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (isChangeCat)
            {
                isChangeCat = false;
                catControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVitCat.Text = "Bật vit Cat";
                btnHandleVitCat.BackColor = Color.White;
            }
            else
            {
                isChangeCat = true;
                catControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVitCat.Text = "Tắt vit Cat";
                btnHandleVitCat.BackColor = Color.Yellow;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isChangePhuGiaKhoang)
            {
                isChangePhuGiaKhoang = false;
                pgkControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVitPGK.Text = "Bật vit PGK";
                btnHandleVitPGK.BackColor = Color.White;
            }
            else
            {
                isChangePhuGiaKhoang = true;
                pgkControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVitPGK.Text = "Tắt vit PGK";
                btnHandleVitPGK.BackColor = Color.Yellow;
            }
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var formChangePW = new ChangePw();
            formChangePW.Show();

            formChangePW.UserLogin = username;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            new ListAccount().Show();
        }

        private void btnLogut_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isChangeXimang)
            {
                isChangeXimang = false;
                ximangControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVitXiMang.Text = "Bật vit Xi Mang";
                btnHandleVitXiMang.BackColor = Color.White;
            }
            else
            {
                isChangeXimang = true;
                ximangControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVitXiMang.Text = "Tắt vit Xi Mang";
                btnHandleVitXiMang.BackColor = Color.Yellow;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isChangeVan1)
            {
                isChangeVan1 = false;
                controlPG1Van1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVan1.Text = "Bật van 1";
                btnHandleVan1.BackColor = Color.White;
            }
            else
            {
                isChangeVan1 = true;
                controlPG1Van1.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVan1.Text = "Tắt van 1";
                btnHandleVan1.BackColor = Color.Yellow;



            }
        }

        private void btnHandleVitTroBay_Click(object sender, EventArgs e)
        {
            if (isChangeTroBay)
            {
                isChangeTroBay = false;
                trobayControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVitTroBay.Text = "Bật vit Tro Bay";
                btnHandleVitTroBay.BackColor = Color.White;
            }
            else
            {
                isChangeTroBay = true;
                trobayControl.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVitTroBay.Text = "Tắt vit Tro Bay";
                btnHandleVitTroBay.BackColor = Color.Yellow;
            }
        }

        private void btnHandleVan2_Click(object sender, EventArgs e)
        {
            if (isChangeVan2)
            {
                isChangeVan2 = false;
                controlPG2Van2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVan2.Text = "Bật van 2";
                btnHandleVan2.BackColor = Color.White;
            }
            else
            {
                isChangeVan2 = true;
                controlPG2Van2.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVan2.Text = "Tắt van 2";
                btnHandleVan2.BackColor = Color.Yellow;



            }
        }

        private void btnHandleVan3_Click(object sender, EventArgs e)
        {
            if (isChangeVan3)
            {
                isChangeVan3 = false;
                controlPG3Van3.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVan3.Text = "Bật van 3";
                btnHandleVan3.BackColor = Color.White;
            }
            else
            {
                isChangeVan3 = true;
                controlPG3Van3.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVan3.Text = "Tắt van 3";
                btnHandleVan3.BackColor = Color.Yellow;



            }
        }

        private void btnHandleVan4_Click(object sender, EventArgs e)
        {
            if (isChangeVan4)
            {
                isChangeVan4 = false;
                controlKGPGVan4.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVan4.Text = "Bật van 4";
                btnHandleVan4.BackColor = Color.White;
            }
            else
            {
                isChangeVan4 = true;
                controlKGPGVan4.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVan4.Text = "Tắt van 4";
                btnHandleVan4.BackColor = Color.Yellow;



            }
        }

        private void btnHandleVan5_Click(object sender, EventArgs e)
        {
            if (isChangeVan5)
            {
                isChangeVan5 = false;
                controlVAN5CANXICAT.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVan5.Text = "Bật van 5";
                btnHandleVan5.BackColor = Color.White;
            }
            else
            {
                isChangeVan5 = true;
                controlVAN5CANXICAT.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVan5.Text = "Tắt van 5";
                btnHandleVan5.BackColor = Color.Yellow;
            }
        }

        private void btnHandleVan6_Click(object sender, EventArgs e)
        {
            if (isChangeVan6)
            {
                isChangeVan6 = false;
                controlTroKhoangVan6.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Original;
                btnHandleVan6.Text = "Bật van 6";
                btnHandleVan6.BackColor = Color.White;
            }
            else
            {
                isChangeVan6 = true;
                controlTroKhoangVan6.FillColorMode = SymbolFactoryNetEngine.FillColorModeOptions.Solid;
                btnHandleVan6.Text = "Tắt van 6";
                btnHandleVan6.BackColor = Color.Yellow;
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            numberCat.Enabled = true;
            numberKhoang.Enabled = true;
            numberPhuGia1.Enabled = true;
            numberPhuGia2.Enabled = true;
            numberPhuGia3.Enabled = true;
            numberTroBay.Enabled = true;
            numberXimang.Enabled = true;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            numberCat.Enabled = false;
            numberKhoang.Enabled = false;
            numberPhuGia1.Enabled = false;
            numberPhuGia2.Enabled = false;
            numberPhuGia3.Enabled = false;
            numberTroBay.Enabled = false;
            numberXimang.Enabled = false;

            Modify modify = new Modify();

            RecipeObj recipeObj = modify.getRecipeDefault();

            numberXimang.Value = recipeObj.xiMang;
            numberTroBay.Value = recipeObj.troBay;
            numberKhoang.Value = recipeObj.khoang;
            numberPhuGia1.Value = recipeObj.pg1;
            numberPhuGia2.Value = recipeObj.pg2;
            numberPhuGia3.Value = recipeObj.pg3;
            numberCat.Value = recipeObj.cat;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numberXimang.Value = 0;
            numberTroBay.Value = 0;
            numberKhoang.Value = 0;
            numberPhuGia1.Value =0;
            numberPhuGia2.Value = 0;
            numberPhuGia3.Value = 0;
            numberCat.Value = 0;
        }
    }
}
