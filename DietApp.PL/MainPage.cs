using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.PL
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Login Page Actions

        private void lp_btn_Entry_Click(object sender, EventArgs e)
        {
            if (lg_tb_Email.Text == "alp" && lg_tb_Password.Text == "alp123")
            {
                lg_tb_Email.Clear();
                lg_tb_Password.Clear();
                pnl_LoginPage.Enabled = false;
                pnl_MainPage.Enabled = true;
                pnl_MainPage.BringToFront();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalı Lütfen Tekrardan Deneyiniz!!!");
            }
        }
        private void lg_btn_Register_Click(object sender, EventArgs e)
        {
            lg_tb_Email.Clear();
            lg_tb_Password.Clear();
            pnl_RegisterPage.BringToFront();
            pnl_LoginPage.Enabled = false;
            pnl_RegisterPage.Enabled = true;
        }

        //Register Page Actions
        private void rg_btn_Register_Click(object sender, EventArgs e)
        {
            rp_tb_Email.Clear();
            rp_tb_Password.Clear();
            rp_tb_Password2.Clear();
            pnl_RegisterPage.Enabled = false;
            pnl_LoginPage.Enabled = true;
            pnl_LoginPage.BringToFront();
        }
        private void rg_btn_Back_Click(object sender, EventArgs e)
        {
            rp_tb_Email.Clear();
            rp_tb_Password.Clear();
            rp_tb_Password2.Clear();
            pnl_RegisterPage.Enabled = false;
            pnl_LoginPage.Enabled = true;
            pnl_LoginPage.BringToFront();

        }

        //Flow Panel Actions
        private void mp_btn_Exit_Click(object sender, EventArgs e)
        {
            pnl_LoginPage.Enabled = true;
            pnl_LoginPage.BringToFront();
        }
    }
}
