using DietApp.BL.Managers;
using DietApp.DAL.Concrete;
using DietApp.DAL.Context;
using DietApp.Entities.Concrete;
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
        UserManager userManager;
        MealTypeManager mealTypeManager;
        CategoryManager categoryManager;

        public MainPage()
        {
            InitializeComponent();
            pnl_LoginPanel.BringToFront();
            userManager = new UserManager(new GenericRepository<User>(new AppDbContext()), new UserRepository(new AppDbContext()));
            mealTypeManager = new MealTypeManager(new GenericRepository<MealType>(new AppDbContext()));
            categoryManager = new CategoryManager(new GenericRepository<Category>(new AppDbContext()));
        }
        private void MainPage_Load(object sender, EventArgs e)
        {

            foreach (var meal in mealTypeManager.GetAll())
            {
                MealPanel_cb_MealSelection.Items.Add(meal.MealName);
            }
            foreach (var category in categoryManager.GetAll()) 
            {
                MealPanel_cb_CatagorySelection.Items.Add(category.CategoryName);
            }
        }

        #region Login Panel
        private void lp_btn_Entry_Click(object sender, EventArgs e)
        {
            userManager.Login(LoginPanel_tb_Email.Text, LoginPanel_tb_Password.Text);
            if (userManager._id != 0)
            {
                ProfilePanel_lbl_Eposta.Text = LoginPanel_tb_Email.Text;
                ProfilePanel_lbl_Password.Text = LoginPanel_tb_Password.Text;

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




        #endregion

        #region Register Panel
        private void rg_btn_Register_Click(object sender, EventArgs e)
        {
            string returnNotification = userManager.AddUser(RegisterPanel_tb_Email.Text, RegisterPanel_tb_Password.Text, RegisterPanel_tb_Password2.Text);
            MessageBox.Show(returnNotification);

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
        #endregion

        #region Flow Panel
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


        #endregion

        #region Profile Panel
        #endregion

        #region Meal Panel

        private void MealPanel_btn_FoodEdit_Click(object sender, EventArgs e)
        {
            if (MealPanel_gb_FoodEditGroupBox.Visible) // yemek güncelleme aktif ise 
            {
                foreach (Control item in pnl_MealPanel.Controls)
                {
                    item.Enabled = true;
                }
                MealPanel_btn_FoodEdit.Enabled = true;
                MealPanel_gb_FoodEditGroupBox.Visible = false;
            }
            else                                       // yemek güncelleme pasif ise 
            {
                foreach (Control item in pnl_MealPanel.Controls)
                {
                    item.Enabled = false;
                }
                MealPanel_btn_FoodEdit.Enabled = true;
                MealPanel_gb_FoodEditGroupBox.Enabled = true;
                MealPanel_gb_FoodEditGroupBox.Visible = true;
            }

        }






        #endregion

        #region Reports Panel
        #endregion








        //Main Page Panel Actions

    }
}
