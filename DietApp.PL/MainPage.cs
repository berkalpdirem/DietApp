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
            if (LoginPanel_tb_Email.Text == "alp" && LoginPanel_tb_Password.Text == "alp123")
            {
                LoginPanel_tb_Email.Clear();
                LoginPanel_tb_Password.Clear();
                pnl_LoginPanel.Enabled = false;

                pnl_ProfilPanel.Enabled = true;
                pnl_FlowPanel.Visible = true;
                pnl_ProfilPanel.BringToFront();
            }
            else
            {
                MessageBox.Show("Giriş Bilgileriniz Hatalı Lütfen Tekrardan Deneyiniz!!!");
            }
        }
        private void lg_btn_Register_Click(object sender, EventArgs e)
        {
            LoginPanel_tb_Email.Clear();
            LoginPanel_tb_Password.Clear();
            pnl_RegisterPage.BringToFront();
            pnl_LoginPanel.Enabled = false;
            pnl_RegisterPage.Enabled = true;
        }

        //Register Page Actions
        private void rg_btn_Register_Click(object sender, EventArgs e)
        {
            RegisterPanel_tb_Email.Clear();
            RegisterPanel_tb_Password.Clear();
            RegisterPanel_tb_Password2.Clear();
            pnl_RegisterPage.Enabled = false;
            pnl_LoginPanel.Enabled = true;
            pnl_LoginPanel.BringToFront();
        }
        private void rg_btn_Back_Click(object sender, EventArgs e)
        {
            RegisterPanel_tb_Email.Clear();
            RegisterPanel_tb_Password.Clear();
            RegisterPanel_tb_Password2.Clear();
            pnl_RegisterPage.Enabled = false;
            pnl_LoginPanel.Enabled = true;
            pnl_LoginPanel.BringToFront();

        }

        //Flow Panel Actions


        private void FlowPanel_btn_Profil_Click(object sender, EventArgs e)
        {
            pnl_FlowPanel.Visible = true;
            pnl_ProfilPanel.BringToFront();

        }
        private void FlowPanel_btn_Meals_Click(object sender, EventArgs e)
        {
            pnl_FlowPanel.BringToFront();
            pnl_MealPanel.BringToFront();


        }

        private void FlowPanel_btn_Reports_Click(object sender, EventArgs e)
        {
            pnl_FlowPanel.BringToFront();
            pnl_ReportsPanel.BringToFront();
        }

        private void mp_btn_Exit_Click(object sender, EventArgs e)
        {
            pnl_FlowPanel.Visible = false;
            pnl_LoginPanel.Enabled = true;
            pnl_LoginPanel.BringToFront();
        }

        private void pnl_LoginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Main Page Panel Actions

    }
}
