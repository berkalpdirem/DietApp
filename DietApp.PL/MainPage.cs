using DietApp.BL.Managers;
using DietApp.DAL.Concrete;
using DietApp.DAL.Context;
using DietApp.Entities.Common;
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
        UserFoodManager userFoodManager;
        UserDayMealFoodManager userDayMealFoodManager;
        public MainPage()
        {
            InitializeComponent();
            pnl_LoginPanel.BringToFront();
            userManager = new UserManager(new GenericRepository<User>(new AppDbContext()), new UserRepository(new AppDbContext()));
            mealTypeManager = new MealTypeManager(new GenericRepository<MealType>(new AppDbContext()));
            categoryManager = new CategoryManager(new GenericRepository<Category>(new AppDbContext()));
            userFoodManager = new UserFoodManager(new GenericRepository<UserFood>(new AppDbContext()), new UserFoodRepository(new AppDbContext()));
            userDayMealFoodManager = new UserDayMealFoodManager(new GenericRepository<UserDayMealFood>(new AppDbContext()), new UserDayMealFoodRepository(new AppDbContext()));
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            MealPanel_gb_MealEditGroupBox.Enabled = false;
            MealPanel_btn_UpdateClose.Visible = false;
        }

        #region HelperMethods
        private void RefleshBoxes()
        {
            MealPanel_cb_MealSelection.Items.Clear();
            MealPanel_cb_CatagorySelection.Items.Clear();
            MealPanel_cb_FoodSelection.Items.Clear();

            MealPanel_cb_MealSelection.Text = "Öğün Seçiniz";
            MealPanel_cb_CatagorySelection.Text = "Kategori Seçiniz";
            MealPanel_cb_FoodSelection.Text = "Yemek Seçiniz";
            MealPanel_nup_PortionSelection.Value = 0;

            foreach (var meal in mealTypeManager.GetAll())
            {
                MealPanel_cb_MealSelection.Items.Add(meal.MealName);

            }
            foreach (var category in categoryManager.GetAll())
            {
                MealPanel_cb_CatagorySelection.Items.Add(category.CategoryName);
            }
            foreach (var userFoodName in userFoodManager.GetUserFoods(userManager._id))
            {

                MealPanel_cb_FoodSelection.Items.Add(userFoodName);
            }
        }
        private void MealGroupBoxClose()
        {
            MealPanel_gb_MealEditGroupBox.Enabled = false;
            MealPanel_gb_MealEditGroupBox.Visible = false;
            MealPanel_btn_MealAdd.Enabled = true;
            MealPanel_btn_UpdateClose.Visible = false;
        }
        public bool checkUIValues(ComboBox MealPanel_cb_MealSelection,
                                  ComboBox MealPanel_cb_CatagorySelection,
                                  ComboBox MealPanel_cb_FoodSelection,
                                  NumericUpDown MealPanel_nup_PortionSelection,
                                  TextBox MealPanel_tb_FoodName,
                                  TextBox MealPanel_tb_FoodCalorie,
                                  string controlButtonText)
        {
            if (controlButtonText == "+")
            {
                if (MealPanel_cb_MealSelection.SelectedIndex != -1 &&
                    MealPanel_cb_CatagorySelection.SelectedIndex != -1 &&
                    MealPanel_cb_FoodSelection.SelectedIndex != -1 &&
                    MealPanel_nup_PortionSelection.Value != 0)

                { return true; }
                else { return false; }
            }
            else // - ise
            {
                if (MealPanel_tb_FoodName.Text != string.Empty &&
                    MealPanel_tb_FoodCalorie.Text != string.Empty &&
                    MealPanel_cb_MealSelection.SelectedIndex != -1 &&
                    MealPanel_cb_CatagorySelection.SelectedIndex != -1 &&
                    MealPanel_nup_PortionSelection.Value != 0)
                { return true; }
                else { return false; }
            }
        }
        #endregion

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
            MealPanel_Datagrid.DataSource = userDayMealFoodManager.ShowDayMealFoods(userManager._id);
            RefleshBoxes();

            pnl_FlowPanel.BringToFront();
            pnl_MealPanel.BringToFront();
        }

        private void FlowPanel_btn_Reports_Click(object sender, EventArgs e)
        {
            ReportsPanel_cb_QuerySelection.SelectedIndex = 0;

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
            // Panel Anismasyonları
            if (!MealPanel_gb_FoodEditGroupBox.Visible) // yemek güncelleme pasif ise (Başlangıçta) 
            {
                MealPanel_cb_FoodSelection.Enabled = false;

                MealPanel_btn_FoodEdit.Enabled = true;
                MealPanel_gb_FoodEditGroupBox.Enabled = true;
                MealPanel_gb_FoodEditGroupBox.Visible = true;

                MealPanel_btn_FoodEdit.Text = "-";
            }
            else                                       // yemek güncelleme aktif ise (+'ya basıldığında) 
            {
                MealPanel_cb_FoodSelection.Enabled = true;

                MealPanel_btn_FoodEdit.Enabled = true;
                MealPanel_gb_FoodEditGroupBox.Visible = false;
                MealPanel_btn_FoodEdit.Text = "+";
            }
        }
        // Yemek Ekleme Operasyonları
        private void MealPanel_btn_MealAdd_Click(object sender, EventArgs e)
        {
            int userIDInput = userManager._id;
            string FoodNameInput = string.Empty;
            decimal PortionInput = 0;
            string CategoryNameInput = string.Empty;
            decimal CalorieInput = 0;
            string MealNameInput = string.Empty;
            DateTime dateTimeInput = MealPanel_DateTimePicker.Value;
            string PhotoPathInput = string.Empty;

            UserDayMealFood relatedDayMealFood = new UserDayMealFood();

            if (MealPanel_btn_FoodEdit.Text == "-")
            {

                if (checkUIValues(MealPanel_cb_MealSelection,
                                   MealPanel_cb_CatagorySelection,
                                   MealPanel_cb_FoodSelection,
                                   MealPanel_nup_PortionSelection,
                                   MealPanel_tb_FoodName,
                                   MealPanel_tb_FoodCalorie,
                                   MealPanel_btn_FoodEdit.Text) && decimal.TryParse(MealPanel_tb_FoodCalorie.Text, out CalorieInput))
                {
                    FoodNameInput = MealPanel_tb_FoodName.Text;
                    PortionInput = MealPanel_nup_PortionSelection.Value;
                    CategoryNameInput = MealPanel_cb_CatagorySelection.Text;
                    //CalorieInput İf'in içinde out ile atanıyor
                    MealNameInput = MealPanel_cb_MealSelection.Text;                                    //Düzenlenecek
                    PhotoPathInput = string.Empty;                                     //Düzenlenecek

                    StructUserDayMealFood structUserDayMealFood = new StructUserDayMealFood()
                    {
                        UserID = userIDInput,
                        FoodName = FoodNameInput,
                        Portion = PortionInput,
                        CategoryName = CategoryNameInput,
                        Calories = CalorieInput,
                        MealName = MealNameInput,
                        DateTime = dateTimeInput,
                        PhotoPath = PhotoPathInput                     //String Empty verdik düzeltilecek
                    };
                    MessageBox.Show(userDayMealFoodManager.AddDayMealFood(structUserDayMealFood));
                    MealPanel_Datagrid.DataSource = userDayMealFoodManager.ShowDayMealFoods(userManager._id);
                    RefleshBoxes();
                }
                else
                {
                    MessageBox.Show(" Veri Girişiniz Hatalı");
                }
            }
            else // + iken -------------------------------------------------------------------------------------------------------
            {
                if (checkUIValues(MealPanel_cb_MealSelection,
                                   MealPanel_cb_CatagorySelection,
                                   MealPanel_cb_FoodSelection,
                                   MealPanel_nup_PortionSelection,
                                   MealPanel_tb_FoodName,
                                   MealPanel_tb_FoodCalorie,
                                   MealPanel_btn_FoodEdit.Text))
                {
                    var UserFood = userFoodManager.GetAll();
                    foreach (var item in UserFood)
                    {
                        if (item.FoodName == MealPanel_cb_FoodSelection.Text)
                        {
                            CalorieInput = item.Calories;
                            break;
                        }
                    }
                    FoodNameInput = MealPanel_cb_FoodSelection.Text;
                    PortionInput = MealPanel_nup_PortionSelection.Value;
                    CategoryNameInput = MealPanel_cb_CatagorySelection.Text;
                    //CalorieInput İf'in içinde out ile atanıyor
                    MealNameInput = MealPanel_cb_MealSelection.Text;
                    PhotoPathInput = string.Empty;                                     //Düzenlenecek

                    StructUserDayMealFood structUserDayMealFood = new StructUserDayMealFood()
                    {
                        UserID = userIDInput,
                        FoodName = FoodNameInput,
                        Portion = PortionInput,
                        CategoryName = CategoryNameInput,
                        Calories = CalorieInput,
                        MealName = MealNameInput,
                        DateTime = dateTimeInput,
                        PhotoPath = PhotoPathInput                     //String Empty verdik düzeltilecek
                    };
                    MessageBox.Show(userDayMealFoodManager.AddDayMealFood(structUserDayMealFood));
                    MealPanel_Datagrid.DataSource = userDayMealFoodManager.ShowDayMealFoods(userManager._id);
                    RefleshBoxes();
                }
                else
                {
                    MessageBox.Show(" Veri Girişiniz Hatalı");
                }
            }
        }

        private void MealPanel_btn_ListDataGrid_Click(object sender, EventArgs e)
        {
            MealPanel_Datagrid.DataSource = userDayMealFoodManager.ShowDayMealFoods(userManager._id);

        }

        private void MealPanel_Datagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Delete Actions
            if (MealPanel_Datagrid.SelectedRows.Count == 1)
            {
                userDayMealFoodManager.CurrentID = int.Parse(MealPanel_Datagrid.SelectedRows[0].Cells[0].Value.ToString());

                MessageBox.Show("Satır Seçimi Başarılı");

                MealPanel_gb_MealEditGroupBox.Enabled = true;
                MealPanel_gb_MealEditGroupBox.Visible = true;
                MealPanel_btn_MealAdd.Enabled = false;
                MealPanel_btn_UpdateClose.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen Satırı Seçiniz");
            }
        }

        private void MealPanel_btn_UpdateClose_Click(object sender, EventArgs e)
        {
            MealGroupBoxClose();
        }

        private void MealPanel_btn_MealUpdate_Click(object sender, EventArgs e)
        {
            int userDayMealInput = userDayMealFoodManager.CurrentID;

            int userIDInput = userManager._id;
            string FoodNameInput = string.Empty;
            decimal PortionInput = 0;
            string CategoryNameInput = string.Empty;
            decimal CalorieInput = 0;
            string MealNameInput = string.Empty;
            DateTime dateTimeInput = MealPanel_DateTimePicker.Value;
            string PhotoPathInput = string.Empty;

            UserDayMealFood relatedDayMealFood = new UserDayMealFood();

            if (MealPanel_btn_FoodEdit.Text == "-")
            {

                if (checkUIValues(MealPanel_cb_MealSelection,
                                   MealPanel_cb_CatagorySelection,
                                   MealPanel_cb_FoodSelection,
                                   MealPanel_nup_PortionSelection,
                                   MealPanel_tb_FoodName,
                                   MealPanel_tb_FoodCalorie,
                                   MealPanel_btn_FoodEdit.Text) && decimal.TryParse(MealPanel_tb_FoodCalorie.Text, out CalorieInput))
                {
                    FoodNameInput = MealPanel_tb_FoodName.Text;
                    PortionInput = MealPanel_nup_PortionSelection.Value;
                    CategoryNameInput = MealPanel_cb_CatagorySelection.Text;
                    //CalorieInput İf'in içinde out ile atanıyor
                    MealNameInput = MealPanel_cb_MealSelection.Text;                                    //Düzenlenecek
                    PhotoPathInput = string.Empty;                                                      //Düzenlenecek

                    StructUserDayMealFood structUserDayMealFood = new StructUserDayMealFood()
                    {
                        ID = userDayMealInput,
                        UserID = userIDInput,
                        FoodName = FoodNameInput,
                        Portion = PortionInput,
                        CategoryName = CategoryNameInput,
                        Calories = CalorieInput,
                        MealName = MealNameInput,
                        DateTime = dateTimeInput,
                        PhotoPath = PhotoPathInput                     //String Empty verdik düzeltilecek
                                                                       // Helper metodu içinde göm ıkısınefde metodla yap

                    };

                    MessageBox.Show(userDayMealFoodManager.UpdateDayMealFood(structUserDayMealFood));
                    MealPanel_Datagrid.DataSource = userDayMealFoodManager.ShowDayMealFoods(userManager._id);
                    RefleshBoxes();
                    MealGroupBoxClose();
                    MessageBox.Show(" Veri Güncellemeniz Başarılı");


                }
                else
                {
                    MessageBox.Show(" Veri Güncellemeniz Hatalı");
                }
            }
            else // + iken
            {
                if (checkUIValues(MealPanel_cb_MealSelection,
                                   MealPanel_cb_CatagorySelection,
                                   MealPanel_cb_FoodSelection,
                                   MealPanel_nup_PortionSelection,
                                   MealPanel_tb_FoodName,
                                   MealPanel_tb_FoodCalorie,
                                   MealPanel_btn_FoodEdit.Text))
                {
                    var UserFood = userFoodManager.GetAll();
                    foreach (var item in UserFood)
                    {
                        if (item.FoodName == MealPanel_cb_FoodSelection.Text)
                        {
                            CalorieInput = item.Calories;
                            break;
                        }
                    }


                    FoodNameInput = MealPanel_cb_FoodSelection.Text;
                    PortionInput = MealPanel_nup_PortionSelection.Value;
                    CategoryNameInput = MealPanel_cb_CatagorySelection.Text;
                    //CalorieInput İf'in içinde out ile atanıyor
                    MealNameInput = MealPanel_cb_MealSelection.Text;                             //Düzenlenecek
                    PhotoPathInput = string.Empty;                                               //Düzenlenecek

                    StructUserDayMealFood structUserDayMealFood = new StructUserDayMealFood()
                    {
                        ID = userDayMealInput,
                        UserID = userIDInput,
                        FoodName = FoodNameInput,
                        Portion = PortionInput,
                        CategoryName = CategoryNameInput,
                        Calories = CalorieInput,
                        MealName = MealNameInput,
                        DateTime = dateTimeInput,                        //Calendardan alınacak
                        PhotoPath = PhotoPathInput                     //String Empty verdik düzeltilecek

                    };
                    MessageBox.Show(userDayMealFoodManager.UpdateDayMealFood(structUserDayMealFood));
                    MealPanel_Datagrid.DataSource = userDayMealFoodManager.ShowDayMealFoods(userManager._id);
                    RefleshBoxes();
                    MealGroupBoxClose();
                    MessageBox.Show(" Veri Güncellemeniz Başarılı");

                }
                else
                {
                    MessageBox.Show(" Veri Güncellemeniz Hatalı");
                }


            }
        }

        private void MealPanel_btn_MealDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userDayMealFoodManager.DeleteDayMealFood(userDayMealFoodManager.CurrentID));
            MealPanel_Datagrid.DataSource = userDayMealFoodManager.ShowDayMealFoods(userManager._id);
            MealGroupBoxClose();
        }
        #endregion

        #region Reports Panel

        private void ReportsPanel_cb_QuerySelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReportsPanel_cb_QuerySelection.SelectedIndex == 0)
            {
                pnl_ReportsPanel_EmptyPanel.BringToFront();
            }
            else if (ReportsPanel_cb_QuerySelection.SelectedIndex == 1)
            {
                pnl_ReportsPanel_DailyCalorieReport.BringToFront();
            }
            else if (ReportsPanel_cb_QuerySelection.SelectedIndex == 2)
            {
                pnl_ReportsPanel_UserCompareReport.BringToFront();
            }
            else if (ReportsPanel_cb_QuerySelection.SelectedIndex == 3)
            {
                pnl_ReportsPanel_MostyEatedFoodsReport.BringToFront();
            }
        }


        private void ReportsPanel_btn_DailyMealCalories_Click(object sender, EventArgs e)
        {
            //Daily Calorie Report with DataGrid
            ReportsPanel_DatagridUserDaily.DataSource = userDayMealFoodManager.ShowDailyMealCalories(userManager._id, ReportsPanel_DateTimePicker.Value);

            List<StructDailyMealCalories> DailyMealList = userDayMealFoodManager.ShowDailyMealCalories(userManager._id, ReportsPanel_DateTimePicker.Value);

            //Total Calorie Calculation
            decimal CaloriesSum = 0;
            foreach (DataGridViewRow row in ReportsPanel_DatagridUserDaily.Rows)
            {
                if (row.Cells["Calories"].Value != null)
                {
                    decimal cellValue;
                    if (decimal.TryParse(row.Cells["Calories"].Value.ToString(), out cellValue))
                    {
                        CaloriesSum += cellValue;
                    }
                }
            }
            ReportsPanel_lbl_TotalDailyCalories.Text = $"{ReportsPanel_DateTimePicker.Value.ToShortDateString()} tarihinde toplam {CaloriesSum} kadar kalori aldınız.";
        }

        private void ReportsPanel_btn_WeekMounthReports_Click(object sender, EventArgs e)
        {


            if (ReportsPanel_rb_MonthllyReport.Checked)
            {
                ReportsPanel_DatagridUserCompare.DataSource = userDayMealFoodManager.ShowReportWeeklyOrMonthlyUserMealCalories(userManager._id, 30);
                ReportsPanel_DatagridOthersCompare.DataSource = userDayMealFoodManager.ShowReportWeeklyOrMonthlyEveryoneMealCalories(userManager._id, 30);


            }
            else if (ReportsPanel_rb_WeeklyReport.Checked)
            {
                ReportsPanel_DatagridUserCompare.DataSource = userDayMealFoodManager.ShowReportWeeklyOrMonthlyUserMealCalories(userManager._id, 7);
                ReportsPanel_DatagridOthersCompare.DataSource = userDayMealFoodManager.ShowReportWeeklyOrMonthlyEveryoneMealCalories(userManager._id, 7);
            }
        }

        private void ReportsPanel_btn_MostlyEatedReports_Click(object sender, EventArgs e)
        {
            ReportsPanel_DatagridMostyEatedFoodsByFoodName.DataSource = userDayMealFoodManager.ShowReportMostEatenFoodsByFoodName(userManager._id);

            ReportsPanel_DatagridMostyEatedFoodsByMealName.DataSource = userDayMealFoodManager.ShowReportMostEatenFoodsByMeaName(userManager._id);
        }



        #endregion

    }
}
