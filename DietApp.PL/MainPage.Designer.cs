namespace DietApp.PL
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_FlowPanel = new Panel();
            FlowPanel_btn_Reports = new Button();
            FlowPanel_btn_Meals = new Button();
            FlowPanel_btn_Profil = new Button();
            FlowPanel_btn_Exit = new Button();
            pnl_MealPanel = new Panel();
            MealPanel_gb_FoodEditGroupBox = new GroupBox();
            MealPanel_tb_FoodCalorie = new TextBox();
            MealPanel_tb_FoodName = new TextBox();
            MealPanel_btn_FoodDelete = new Button();
            MealPanel_btn_FoodUpdate = new Button();
            MealPanel_btn_FoodAdd = new Button();
            MealPanel_lbl_MealSelection = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            MealPanel_nup_PortionSelection = new NumericUpDown();
            MealPanel_FoodImage = new PictureBox();
            MealPanel_cb_CatagorySelection = new ComboBox();
            MealPanel_cb_FoodSelection = new ComboBox();
            MealPanel_cb_MealSelection = new ComboBox();
            MealPanel_Calendar = new MonthCalendar();
            MealPanel_Datagrid = new DataGridView();
            MealPanel_btn_FoodEdit = new Button();
            pnl_LoginPanel = new Panel();
            LoginPage_gp_Actions = new GroupBox();
            LoginPanel_btn_Register = new Button();
            LoginPanel_tb_Email = new TextBox();
            LoginPanel_btn_Entry = new Button();
            LoginPanel_tb_Password = new TextBox();
            pnl_RegisterPage = new Panel();
            RegisterPanel_btn_Back = new Button();
            RegisterPanel_btn_Register = new Button();
            RegisterPanel_tb_Password2 = new TextBox();
            RegisterPanel_tb_Password = new TextBox();
            RegisterPanel_tb_Email = new TextBox();
            pnl_ProfilPanel = new Panel();
            ProfilPanel_gp_Info = new GroupBox();
            pictureBox1 = new PictureBox();
            ProfilePanel_lbl_Surname = new Label();
            ProfilePanel_lbl_Name = new Label();
            ProfilePanel_lbl_Password = new Label();
            ProfilePanel_lbl_Eposta = new Label();
            ProfilPanel_lbl_Concrate1 = new Label();
            ProfilPanel_lbl_Concrate2 = new Label();
            ProfilPanel_lbl_Concrate3 = new Label();
            ProfilPanel_lbl_Concrate4 = new Label();
            pnl_ReportsPanel = new Panel();
            ReportsPanel_Calendar = new MonthCalendar();
            ReportsPanel_Datagrid = new DataGridView();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            ReportsPanel_cb_QuerySelection = new ComboBox();
            ProfilPanel_lbl_Concrate5 = new Label();
            ProfilPanel_lbl_Concrate6 = new Label();
            ProfilPanel_lbl_Concrate7 = new Label();
            ProfilePanel_lbl_Heights = new Label();
            ProfilePanel_lbl_Weight = new Label();
            ProfilePanel_lbl_Index = new Label();
            pnl_FlowPanel.SuspendLayout();
            pnl_MealPanel.SuspendLayout();
            MealPanel_gb_FoodEditGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MealPanel_nup_PortionSelection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MealPanel_FoodImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MealPanel_Datagrid).BeginInit();
            pnl_LoginPanel.SuspendLayout();
            LoginPage_gp_Actions.SuspendLayout();
            pnl_RegisterPage.SuspendLayout();
            pnl_ProfilPanel.SuspendLayout();
            ProfilPanel_gp_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_ReportsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ReportsPanel_Datagrid).BeginInit();
            SuspendLayout();
            // 
            // pnl_FlowPanel
            // 
            pnl_FlowPanel.BackColor = Color.FromArgb(35, 40, 45);
            pnl_FlowPanel.Controls.Add(FlowPanel_btn_Reports);
            pnl_FlowPanel.Controls.Add(FlowPanel_btn_Meals);
            pnl_FlowPanel.Controls.Add(FlowPanel_btn_Profil);
            pnl_FlowPanel.Controls.Add(FlowPanel_btn_Exit);
            pnl_FlowPanel.Dock = DockStyle.Left;
            pnl_FlowPanel.Location = new Point(0, 0);
            pnl_FlowPanel.Name = "pnl_FlowPanel";
            pnl_FlowPanel.Size = new Size(210, 450);
            pnl_FlowPanel.TabIndex = 0;
            pnl_FlowPanel.Visible = false;
            // 
            // FlowPanel_btn_Reports
            // 
            FlowPanel_btn_Reports.Location = new Point(28, 268);
            FlowPanel_btn_Reports.Name = "FlowPanel_btn_Reports";
            FlowPanel_btn_Reports.Size = new Size(137, 39);
            FlowPanel_btn_Reports.TabIndex = 2;
            FlowPanel_btn_Reports.Text = "Genel Raporlar";
            FlowPanel_btn_Reports.UseVisualStyleBackColor = true;
            FlowPanel_btn_Reports.Click += FlowPanel_btn_Reports_Click;
            // 
            // FlowPanel_btn_Meals
            // 
            FlowPanel_btn_Meals.Location = new Point(28, 154);
            FlowPanel_btn_Meals.Name = "FlowPanel_btn_Meals";
            FlowPanel_btn_Meals.Size = new Size(137, 38);
            FlowPanel_btn_Meals.TabIndex = 2;
            FlowPanel_btn_Meals.Text = "Öğünlerim";
            FlowPanel_btn_Meals.UseVisualStyleBackColor = true;
            FlowPanel_btn_Meals.Click += FlowPanel_btn_Meals_Click;
            // 
            // FlowPanel_btn_Profil
            // 
            FlowPanel_btn_Profil.Location = new Point(28, 39);
            FlowPanel_btn_Profil.Name = "FlowPanel_btn_Profil";
            FlowPanel_btn_Profil.Size = new Size(137, 39);
            FlowPanel_btn_Profil.TabIndex = 2;
            FlowPanel_btn_Profil.Text = "Profil";
            FlowPanel_btn_Profil.UseVisualStyleBackColor = true;
            FlowPanel_btn_Profil.Click += FlowPanel_btn_Profil_Click;
            // 
            // FlowPanel_btn_Exit
            // 
            FlowPanel_btn_Exit.Location = new Point(28, 384);
            FlowPanel_btn_Exit.Name = "FlowPanel_btn_Exit";
            FlowPanel_btn_Exit.Size = new Size(137, 38);
            FlowPanel_btn_Exit.TabIndex = 0;
            FlowPanel_btn_Exit.Text = "Çıkış";
            FlowPanel_btn_Exit.UseVisualStyleBackColor = true;
            FlowPanel_btn_Exit.Click += mp_btn_Exit_Click;
            // 
            // pnl_MealPanel
            // 
            pnl_MealPanel.BackColor = SystemColors.ButtonShadow;
            pnl_MealPanel.Controls.Add(MealPanel_gb_FoodEditGroupBox);
            pnl_MealPanel.Controls.Add(MealPanel_lbl_MealSelection);
            pnl_MealPanel.Controls.Add(label3);
            pnl_MealPanel.Controls.Add(label2);
            pnl_MealPanel.Controls.Add(label1);
            pnl_MealPanel.Controls.Add(MealPanel_nup_PortionSelection);
            pnl_MealPanel.Controls.Add(MealPanel_FoodImage);
            pnl_MealPanel.Controls.Add(MealPanel_cb_CatagorySelection);
            pnl_MealPanel.Controls.Add(MealPanel_cb_FoodSelection);
            pnl_MealPanel.Controls.Add(MealPanel_cb_MealSelection);
            pnl_MealPanel.Controls.Add(MealPanel_Calendar);
            pnl_MealPanel.Controls.Add(MealPanel_Datagrid);
            pnl_MealPanel.Controls.Add(MealPanel_btn_FoodEdit);
            pnl_MealPanel.Dock = DockStyle.Fill;
            pnl_MealPanel.Location = new Point(210, 0);
            pnl_MealPanel.Name = "pnl_MealPanel";
            pnl_MealPanel.Size = new Size(698, 450);
            pnl_MealPanel.TabIndex = 2;
            // 
            // MealPanel_gb_FoodEditGroupBox
            // 
            MealPanel_gb_FoodEditGroupBox.Controls.Add(MealPanel_tb_FoodCalorie);
            MealPanel_gb_FoodEditGroupBox.Controls.Add(MealPanel_tb_FoodName);
            MealPanel_gb_FoodEditGroupBox.Controls.Add(MealPanel_btn_FoodDelete);
            MealPanel_gb_FoodEditGroupBox.Controls.Add(MealPanel_btn_FoodUpdate);
            MealPanel_gb_FoodEditGroupBox.Controls.Add(MealPanel_btn_FoodAdd);
            MealPanel_gb_FoodEditGroupBox.Location = new Point(7, 146);
            MealPanel_gb_FoodEditGroupBox.Name = "MealPanel_gb_FoodEditGroupBox";
            MealPanel_gb_FoodEditGroupBox.Size = new Size(433, 77);
            MealPanel_gb_FoodEditGroupBox.TabIndex = 8;
            MealPanel_gb_FoodEditGroupBox.TabStop = false;
            MealPanel_gb_FoodEditGroupBox.Text = "Yemek Düzenle";
            MealPanel_gb_FoodEditGroupBox.Visible = false;
            // 
            // MealPanel_tb_FoodCalorie
            // 
            MealPanel_tb_FoodCalorie.Location = new Point(207, 26);
            MealPanel_tb_FoodCalorie.Name = "MealPanel_tb_FoodCalorie";
            MealPanel_tb_FoodCalorie.PlaceholderText = "Yemeğin 1 Porsiyondaki Kalorisini Giriniz";
            MealPanel_tb_FoodCalorie.Size = new Size(226, 23);
            MealPanel_tb_FoodCalorie.TabIndex = 11;
            // 
            // MealPanel_tb_FoodName
            // 
            MealPanel_tb_FoodName.Location = new Point(0, 26);
            MealPanel_tb_FoodName.Name = "MealPanel_tb_FoodName";
            MealPanel_tb_FoodName.PlaceholderText = "Yemek İsmini Giriniz";
            MealPanel_tb_FoodName.Size = new Size(201, 23);
            MealPanel_tb_FoodName.TabIndex = 12;
            // 
            // MealPanel_btn_FoodDelete
            // 
            MealPanel_btn_FoodDelete.Location = new Point(308, 51);
            MealPanel_btn_FoodDelete.Name = "MealPanel_btn_FoodDelete";
            MealPanel_btn_FoodDelete.Size = new Size(125, 23);
            MealPanel_btn_FoodDelete.TabIndex = 8;
            MealPanel_btn_FoodDelete.Text = "Yemek Sil";
            MealPanel_btn_FoodDelete.UseVisualStyleBackColor = true;
            // 
            // MealPanel_btn_FoodUpdate
            // 
            MealPanel_btn_FoodUpdate.Location = new Point(150, 51);
            MealPanel_btn_FoodUpdate.Name = "MealPanel_btn_FoodUpdate";
            MealPanel_btn_FoodUpdate.Size = new Size(140, 23);
            MealPanel_btn_FoodUpdate.TabIndex = 9;
            MealPanel_btn_FoodUpdate.Text = "Yemek Düzenle";
            MealPanel_btn_FoodUpdate.UseVisualStyleBackColor = true;
            // 
            // MealPanel_btn_FoodAdd
            // 
            MealPanel_btn_FoodAdd.Location = new Point(-1, 51);
            MealPanel_btn_FoodAdd.Name = "MealPanel_btn_FoodAdd";
            MealPanel_btn_FoodAdd.Size = new Size(121, 23);
            MealPanel_btn_FoodAdd.TabIndex = 10;
            MealPanel_btn_FoodAdd.Text = "Yemek Ekle";
            MealPanel_btn_FoodAdd.UseVisualStyleBackColor = true;
            // 
            // MealPanel_lbl_MealSelection
            // 
            MealPanel_lbl_MealSelection.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MealPanel_lbl_MealSelection.Location = new Point(6, 15);
            MealPanel_lbl_MealSelection.Name = "MealPanel_lbl_MealSelection";
            MealPanel_lbl_MealSelection.Size = new Size(154, 23);
            MealPanel_lbl_MealSelection.TabIndex = 6;
            MealPanel_lbl_MealSelection.Text = "Öğününüzü Seçiniz:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 41);
            label3.Name = "label3";
            label3.Size = new Size(162, 22);
            label3.TabIndex = 6;
            label3.Text = "Yemek Kategorinizi Seçiniz:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 69);
            label2.Name = "label2";
            label2.Size = new Size(154, 23);
            label2.TabIndex = 6;
            label2.Text = "Yemeğinizi Seçiniz:";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 97);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 6;
            label1.Text = "Porsiyon Giriniz:";
            // 
            // MealPanel_nup_PortionSelection
            // 
            MealPanel_nup_PortionSelection.DecimalPlaces = 1;
            MealPanel_nup_PortionSelection.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            MealPanel_nup_PortionSelection.Location = new Point(166, 95);
            MealPanel_nup_PortionSelection.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            MealPanel_nup_PortionSelection.Name = "MealPanel_nup_PortionSelection";
            MealPanel_nup_PortionSelection.Size = new Size(140, 23);
            MealPanel_nup_PortionSelection.TabIndex = 5;
            // 
            // MealPanel_FoodImage
            // 
            MealPanel_FoodImage.Image = Properties.Resources.YemekFoto;
            MealPanel_FoodImage.Location = new Point(312, 12);
            MealPanel_FoodImage.Name = "MealPanel_FoodImage";
            MealPanel_FoodImage.Size = new Size(128, 121);
            MealPanel_FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            MealPanel_FoodImage.TabIndex = 4;
            MealPanel_FoodImage.TabStop = false;
            // 
            // MealPanel_cb_CatagorySelection
            // 
            MealPanel_cb_CatagorySelection.FormattingEnabled = true;
            MealPanel_cb_CatagorySelection.Location = new Point(166, 38);
            MealPanel_cb_CatagorySelection.Name = "MealPanel_cb_CatagorySelection";
            MealPanel_cb_CatagorySelection.Size = new Size(140, 23);
            MealPanel_cb_CatagorySelection.TabIndex = 3;
            MealPanel_cb_CatagorySelection.Text = "Katagori İsmini Seçiniz";
            // 
            // MealPanel_cb_FoodSelection
            // 
            MealPanel_cb_FoodSelection.FormattingEnabled = true;
            MealPanel_cb_FoodSelection.Location = new Point(166, 66);
            MealPanel_cb_FoodSelection.Name = "MealPanel_cb_FoodSelection";
            MealPanel_cb_FoodSelection.Size = new Size(140, 23);
            MealPanel_cb_FoodSelection.TabIndex = 3;
            MealPanel_cb_FoodSelection.Text = "Yemek İsmini Seçiniz";
            // 
            // MealPanel_cb_MealSelection
            // 
            MealPanel_cb_MealSelection.AccessibleName = "";
            MealPanel_cb_MealSelection.FormattingEnabled = true;
            MealPanel_cb_MealSelection.Location = new Point(166, 12);
            MealPanel_cb_MealSelection.Name = "MealPanel_cb_MealSelection";
            MealPanel_cb_MealSelection.Size = new Size(140, 23);
            MealPanel_cb_MealSelection.TabIndex = 3;
            MealPanel_cb_MealSelection.Text = "Öğünüzü Seçiniz";
            // 
            // MealPanel_Calendar
            // 
            MealPanel_Calendar.Location = new Point(453, 30);
            MealPanel_Calendar.MaxDate = new DateTime(2023, 9, 27, 0, 0, 0, 0);
            MealPanel_Calendar.Name = "MealPanel_Calendar";
            MealPanel_Calendar.TabIndex = 2;
            // 
            // MealPanel_Datagrid
            // 
            MealPanel_Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MealPanel_Datagrid.Location = new Point(7, 229);
            MealPanel_Datagrid.Name = "MealPanel_Datagrid";
            MealPanel_Datagrid.RowTemplate.Height = 25;
            MealPanel_Datagrid.Size = new Size(669, 191);
            MealPanel_Datagrid.TabIndex = 1;
            // 
            // MealPanel_btn_FoodEdit
            // 
            MealPanel_btn_FoodEdit.Location = new Point(7, 123);
            MealPanel_btn_FoodEdit.Name = "MealPanel_btn_FoodEdit";
            MealPanel_btn_FoodEdit.Size = new Size(104, 23);
            MealPanel_btn_FoodEdit.TabIndex = 0;
            MealPanel_btn_FoodEdit.Text = "Yemek Güncelle";
            MealPanel_btn_FoodEdit.UseVisualStyleBackColor = true;
            MealPanel_btn_FoodEdit.Click += MealPanel_btn_FoodEdit_Click;
            // 
            // pnl_LoginPanel
            // 
            pnl_LoginPanel.BackColor = SystemColors.ButtonShadow;
            pnl_LoginPanel.Controls.Add(LoginPage_gp_Actions);
            pnl_LoginPanel.Dock = DockStyle.Fill;
            pnl_LoginPanel.Location = new Point(210, 0);
            pnl_LoginPanel.Name = "pnl_LoginPanel";
            pnl_LoginPanel.Size = new Size(698, 450);
            pnl_LoginPanel.TabIndex = 1;
            // 
            // LoginPage_gp_Actions
            // 
            LoginPage_gp_Actions.Controls.Add(LoginPanel_btn_Register);
            LoginPage_gp_Actions.Controls.Add(LoginPanel_tb_Email);
            LoginPage_gp_Actions.Controls.Add(LoginPanel_btn_Entry);
            LoginPage_gp_Actions.Controls.Add(LoginPanel_tb_Password);
            LoginPage_gp_Actions.Location = new Point(275, 142);
            LoginPage_gp_Actions.Name = "LoginPage_gp_Actions";
            LoginPage_gp_Actions.Size = new Size(246, 149);
            LoginPage_gp_Actions.TabIndex = 5;
            LoginPage_gp_Actions.TabStop = false;
            // 
            // LoginPanel_btn_Register
            // 
            LoginPanel_btn_Register.Location = new Point(124, 87);
            LoginPanel_btn_Register.Name = "LoginPanel_btn_Register";
            LoginPanel_btn_Register.Size = new Size(100, 23);
            LoginPanel_btn_Register.TabIndex = 4;
            LoginPanel_btn_Register.Text = "Kayıt Ol";
            LoginPanel_btn_Register.UseVisualStyleBackColor = true;
            LoginPanel_btn_Register.Click += lg_btn_Register_Click;
            // 
            // LoginPanel_tb_Email
            // 
            LoginPanel_tb_Email.Location = new Point(18, 29);
            LoginPanel_tb_Email.Name = "LoginPanel_tb_Email";
            LoginPanel_tb_Email.PlaceholderText = "E-Mail";
            LoginPanel_tb_Email.Size = new Size(206, 23);
            LoginPanel_tb_Email.TabIndex = 1;
            // 
            // LoginPanel_btn_Entry
            // 
            LoginPanel_btn_Entry.Location = new Point(18, 87);
            LoginPanel_btn_Entry.Name = "LoginPanel_btn_Entry";
            LoginPanel_btn_Entry.Size = new Size(100, 23);
            LoginPanel_btn_Entry.TabIndex = 3;
            LoginPanel_btn_Entry.Text = "Giriş";
            LoginPanel_btn_Entry.UseVisualStyleBackColor = true;
            LoginPanel_btn_Entry.Click += lp_btn_Entry_Click;
            // 
            // LoginPanel_tb_Password
            // 
            LoginPanel_tb_Password.Location = new Point(18, 58);
            LoginPanel_tb_Password.Name = "LoginPanel_tb_Password";
            LoginPanel_tb_Password.PlaceholderText = "Şifre";
            LoginPanel_tb_Password.Size = new Size(206, 23);
            LoginPanel_tb_Password.TabIndex = 2;
            // 
            // pnl_RegisterPage
            // 
            pnl_RegisterPage.BackColor = SystemColors.ButtonShadow;
            pnl_RegisterPage.Controls.Add(RegisterPanel_btn_Back);
            pnl_RegisterPage.Controls.Add(RegisterPanel_btn_Register);
            pnl_RegisterPage.Controls.Add(RegisterPanel_tb_Password2);
            pnl_RegisterPage.Controls.Add(RegisterPanel_tb_Password);
            pnl_RegisterPage.Controls.Add(RegisterPanel_tb_Email);
            pnl_RegisterPage.Dock = DockStyle.Fill;
            pnl_RegisterPage.Enabled = false;
            pnl_RegisterPage.Location = new Point(210, 0);
            pnl_RegisterPage.Name = "pnl_RegisterPage";
            pnl_RegisterPage.Size = new Size(698, 450);
            pnl_RegisterPage.TabIndex = 2;
            // 
            // RegisterPanel_btn_Back
            // 
            RegisterPanel_btn_Back.Location = new Point(391, 229);
            RegisterPanel_btn_Back.Name = "RegisterPanel_btn_Back";
            RegisterPanel_btn_Back.Size = new Size(70, 23);
            RegisterPanel_btn_Back.TabIndex = 5;
            RegisterPanel_btn_Back.Text = " Geri";
            RegisterPanel_btn_Back.UseVisualStyleBackColor = true;
            RegisterPanel_btn_Back.Click += rg_btn_Back_Click;
            // 
            // RegisterPanel_btn_Register
            // 
            RegisterPanel_btn_Register.Location = new Point(315, 229);
            RegisterPanel_btn_Register.Name = "RegisterPanel_btn_Register";
            RegisterPanel_btn_Register.Size = new Size(70, 23);
            RegisterPanel_btn_Register.TabIndex = 4;
            RegisterPanel_btn_Register.Text = "Kayıt Ol";
            RegisterPanel_btn_Register.UseVisualStyleBackColor = true;
            RegisterPanel_btn_Register.Click += rg_btn_Register_Click;
            // 
            // RegisterPanel_tb_Password2
            // 
            RegisterPanel_tb_Password2.Location = new Point(315, 200);
            RegisterPanel_tb_Password2.Name = "RegisterPanel_tb_Password2";
            RegisterPanel_tb_Password2.PlaceholderText = "Şifrenizi Tekrardan Giriniz";
            RegisterPanel_tb_Password2.Size = new Size(146, 23);
            RegisterPanel_tb_Password2.TabIndex = 3;
            // 
            // RegisterPanel_tb_Password
            // 
            RegisterPanel_tb_Password.Location = new Point(315, 171);
            RegisterPanel_tb_Password.Name = "RegisterPanel_tb_Password";
            RegisterPanel_tb_Password.PlaceholderText = "Şifrenizi Giriniz";
            RegisterPanel_tb_Password.Size = new Size(146, 23);
            RegisterPanel_tb_Password.TabIndex = 2;
            // 
            // RegisterPanel_tb_Email
            // 
            RegisterPanel_tb_Email.Location = new Point(315, 142);
            RegisterPanel_tb_Email.Name = "RegisterPanel_tb_Email";
            RegisterPanel_tb_Email.PlaceholderText = "E-Mailinizi Giriniz";
            RegisterPanel_tb_Email.Size = new Size(146, 23);
            RegisterPanel_tb_Email.TabIndex = 1;
            // 
            // pnl_ProfilPanel
            // 
            pnl_ProfilPanel.BackColor = SystemColors.ButtonShadow;
            pnl_ProfilPanel.Controls.Add(ProfilPanel_gp_Info);
            pnl_ProfilPanel.Dock = DockStyle.Fill;
            pnl_ProfilPanel.Location = new Point(210, 0);
            pnl_ProfilPanel.Name = "pnl_ProfilPanel";
            pnl_ProfilPanel.Size = new Size(698, 450);
            pnl_ProfilPanel.TabIndex = 2;
            // 
            // ProfilPanel_gp_Info
            // 
            ProfilPanel_gp_Info.Controls.Add(pictureBox1);
            ProfilPanel_gp_Info.Controls.Add(ProfilePanel_lbl_Surname);
            ProfilPanel_gp_Info.Controls.Add(ProfilePanel_lbl_Index);
            ProfilPanel_gp_Info.Controls.Add(ProfilePanel_lbl_Name);
            ProfilPanel_gp_Info.Controls.Add(ProfilePanel_lbl_Weight);
            ProfilPanel_gp_Info.Controls.Add(ProfilePanel_lbl_Password);
            ProfilPanel_gp_Info.Controls.Add(ProfilePanel_lbl_Heights);
            ProfilPanel_gp_Info.Controls.Add(ProfilePanel_lbl_Eposta);
            ProfilPanel_gp_Info.Controls.Add(ProfilPanel_lbl_Concrate1);
            ProfilPanel_gp_Info.Controls.Add(ProfilPanel_lbl_Concrate2);
            ProfilPanel_gp_Info.Controls.Add(ProfilPanel_lbl_Concrate3);
            ProfilPanel_gp_Info.Controls.Add(ProfilPanel_lbl_Concrate4);
            ProfilPanel_gp_Info.Controls.Add(ProfilPanel_lbl_Concrate5);
            ProfilPanel_gp_Info.Controls.Add(ProfilPanel_lbl_Concrate6);
            ProfilPanel_gp_Info.Controls.Add(ProfilPanel_lbl_Concrate7);
            ProfilPanel_gp_Info.Location = new Point(181, 32);
            ProfilPanel_gp_Info.Name = "ProfilPanel_gp_Info";
            ProfilPanel_gp_Info.Size = new Size(256, 313);
            ProfilPanel_gp_Info.TabIndex = 2;
            ProfilPanel_gp_Info.TabStop = false;
            ProfilPanel_gp_Info.Text = "Profil Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.emptyProfileImg;
            pictureBox1.Location = new Point(94, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ProfilePanel_lbl_Surname
            // 
            ProfilePanel_lbl_Surname.AutoSize = true;
            ProfilePanel_lbl_Surname.Location = new Point(131, 188);
            ProfilePanel_lbl_Surname.Name = "ProfilePanel_lbl_Surname";
            ProfilePanel_lbl_Surname.Size = new Size(12, 15);
            ProfilePanel_lbl_Surname.TabIndex = 1;
            ProfilePanel_lbl_Surname.Text = "-";
            // 
            // ProfilePanel_lbl_Name
            // 
            ProfilePanel_lbl_Name.AutoSize = true;
            ProfilePanel_lbl_Name.Location = new Point(131, 168);
            ProfilePanel_lbl_Name.Name = "ProfilePanel_lbl_Name";
            ProfilePanel_lbl_Name.Size = new Size(12, 15);
            ProfilePanel_lbl_Name.TabIndex = 1;
            ProfilePanel_lbl_Name.Text = "-";
            // 
            // ProfilePanel_lbl_Password
            // 
            ProfilePanel_lbl_Password.AutoSize = true;
            ProfilePanel_lbl_Password.Location = new Point(131, 147);
            ProfilePanel_lbl_Password.Name = "ProfilePanel_lbl_Password";
            ProfilePanel_lbl_Password.Size = new Size(12, 15);
            ProfilePanel_lbl_Password.TabIndex = 1;
            ProfilePanel_lbl_Password.Text = "-";
            // 
            // ProfilePanel_lbl_Eposta
            // 
            ProfilePanel_lbl_Eposta.AutoSize = true;
            ProfilePanel_lbl_Eposta.Location = new Point(131, 122);
            ProfilePanel_lbl_Eposta.Name = "ProfilePanel_lbl_Eposta";
            ProfilePanel_lbl_Eposta.Size = new Size(12, 15);
            ProfilePanel_lbl_Eposta.TabIndex = 1;
            ProfilePanel_lbl_Eposta.Text = "-";
            // 
            // ProfilPanel_lbl_Concrate1
            // 
            ProfilPanel_lbl_Concrate1.AutoSize = true;
            ProfilPanel_lbl_Concrate1.Location = new Point(18, 122);
            ProfilPanel_lbl_Concrate1.Name = "ProfilPanel_lbl_Concrate1";
            ProfilPanel_lbl_Concrate1.Size = new Size(53, 15);
            ProfilPanel_lbl_Concrate1.TabIndex = 1;
            ProfilPanel_lbl_Concrate1.Text = "E-Posta :";
            // 
            // ProfilPanel_lbl_Concrate2
            // 
            ProfilPanel_lbl_Concrate2.AutoSize = true;
            ProfilPanel_lbl_Concrate2.Location = new Point(17, 145);
            ProfilPanel_lbl_Concrate2.Name = "ProfilPanel_lbl_Concrate2";
            ProfilPanel_lbl_Concrate2.Size = new Size(33, 15);
            ProfilPanel_lbl_Concrate2.TabIndex = 1;
            ProfilPanel_lbl_Concrate2.Text = "Şifre:";
            // 
            // ProfilPanel_lbl_Concrate3
            // 
            ProfilPanel_lbl_Concrate3.AutoSize = true;
            ProfilPanel_lbl_Concrate3.Location = new Point(18, 165);
            ProfilPanel_lbl_Concrate3.Name = "ProfilPanel_lbl_Concrate3";
            ProfilPanel_lbl_Concrate3.Size = new Size(32, 15);
            ProfilPanel_lbl_Concrate3.TabIndex = 1;
            ProfilPanel_lbl_Concrate3.Text = "İsim:";
            // 
            // ProfilPanel_lbl_Concrate4
            // 
            ProfilPanel_lbl_Concrate4.AutoSize = true;
            ProfilPanel_lbl_Concrate4.Location = new Point(15, 188);
            ProfilPanel_lbl_Concrate4.Name = "ProfilPanel_lbl_Concrate4";
            ProfilPanel_lbl_Concrate4.Size = new Size(54, 15);
            ProfilPanel_lbl_Concrate4.TabIndex = 1;
            ProfilPanel_lbl_Concrate4.Text = "Soy İsim:";
            // 
            // pnl_ReportsPanel
            // 
            pnl_ReportsPanel.BackColor = SystemColors.ButtonShadow;
            pnl_ReportsPanel.Controls.Add(ReportsPanel_Calendar);
            pnl_ReportsPanel.Controls.Add(ReportsPanel_Datagrid);
            pnl_ReportsPanel.Controls.Add(comboBox2);
            pnl_ReportsPanel.Controls.Add(comboBox1);
            pnl_ReportsPanel.Controls.Add(ReportsPanel_cb_QuerySelection);
            pnl_ReportsPanel.Dock = DockStyle.Fill;
            pnl_ReportsPanel.Location = new Point(210, 0);
            pnl_ReportsPanel.Name = "pnl_ReportsPanel";
            pnl_ReportsPanel.Size = new Size(698, 450);
            pnl_ReportsPanel.TabIndex = 5;
            // 
            // ReportsPanel_Calendar
            // 
            ReportsPanel_Calendar.Location = new Point(400, 0);
            ReportsPanel_Calendar.MaxDate = new DateTime(2023, 9, 27, 0, 0, 0, 0);
            ReportsPanel_Calendar.Name = "ReportsPanel_Calendar";
            ReportsPanel_Calendar.TabIndex = 2;
            // 
            // ReportsPanel_Datagrid
            // 
            ReportsPanel_Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportsPanel_Datagrid.Location = new Point(45, 200);
            ReportsPanel_Datagrid.Name = "ReportsPanel_Datagrid";
            ReportsPanel_Datagrid.RowTemplate.Height = 25;
            ReportsPanel_Datagrid.Size = new Size(540, 220);
            ReportsPanel_Datagrid.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(133, 55);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 0;
            comboBox2.Text = "Yemekler";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Öğünler";
            // 
            // ReportsPanel_cb_QuerySelection
            // 
            ReportsPanel_cb_QuerySelection.FormattingEnabled = true;
            ReportsPanel_cb_QuerySelection.Items.AddRange(new object[] { "Belirtilen Günün Genel Raporu", "En Çok Yenen Yemekler Raporu", "Öğünlerin Diğer Kullanıcılar İle Kıyaslanma Raporu" });
            ReportsPanel_cb_QuerySelection.Location = new Point(6, 25);
            ReportsPanel_cb_QuerySelection.Name = "ReportsPanel_cb_QuerySelection";
            ReportsPanel_cb_QuerySelection.Size = new Size(248, 23);
            ReportsPanel_cb_QuerySelection.TabIndex = 0;
            ReportsPanel_cb_QuerySelection.Text = "Genel Raporlar";
            // 
            // ProfilPanel_lbl_Concrate5
            // 
            ProfilPanel_lbl_Concrate5.AutoSize = true;
            ProfilPanel_lbl_Concrate5.Location = new Point(15, 214);
            ProfilPanel_lbl_Concrate5.Name = "ProfilPanel_lbl_Concrate5";
            ProfilPanel_lbl_Concrate5.Size = new Size(30, 15);
            ProfilPanel_lbl_Concrate5.TabIndex = 1;
            ProfilPanel_lbl_Concrate5.Text = "Boy:";
            // 
            // ProfilPanel_lbl_Concrate6
            // 
            ProfilPanel_lbl_Concrate6.AutoSize = true;
            ProfilPanel_lbl_Concrate6.Location = new Point(17, 236);
            ProfilPanel_lbl_Concrate6.Name = "ProfilPanel_lbl_Concrate6";
            ProfilPanel_lbl_Concrate6.Size = new Size(33, 15);
            ProfilPanel_lbl_Concrate6.TabIndex = 1;
            ProfilPanel_lbl_Concrate6.Text = "Kilo :";
            // 
            // ProfilPanel_lbl_Concrate7
            // 
            ProfilPanel_lbl_Concrate7.AutoSize = true;
            ProfilPanel_lbl_Concrate7.Location = new Point(18, 260);
            ProfilPanel_lbl_Concrate7.Name = "ProfilPanel_lbl_Concrate7";
            ProfilPanel_lbl_Concrate7.Size = new Size(102, 15);
            ProfilPanel_lbl_Concrate7.TabIndex = 1;
            ProfilPanel_lbl_Concrate7.Text = "Vücut Kitle İndexi:";
            // 
            // ProfilePanel_lbl_Heights
            // 
            ProfilePanel_lbl_Heights.AutoSize = true;
            ProfilePanel_lbl_Heights.Location = new Point(131, 214);
            ProfilePanel_lbl_Heights.Name = "ProfilePanel_lbl_Heights";
            ProfilePanel_lbl_Heights.Size = new Size(12, 15);
            ProfilePanel_lbl_Heights.TabIndex = 1;
            ProfilePanel_lbl_Heights.Text = "-";
            // 
            // ProfilePanel_lbl_Weight
            // 
            ProfilePanel_lbl_Weight.AutoSize = true;
            ProfilePanel_lbl_Weight.Location = new Point(131, 239);
            ProfilePanel_lbl_Weight.Name = "ProfilePanel_lbl_Weight";
            ProfilePanel_lbl_Weight.Size = new Size(12, 15);
            ProfilePanel_lbl_Weight.TabIndex = 1;
            ProfilePanel_lbl_Weight.Text = "-";
            // 
            // ProfilePanel_lbl_Index
            // 
            ProfilePanel_lbl_Index.AutoSize = true;
            ProfilePanel_lbl_Index.Location = new Point(131, 260);
            ProfilePanel_lbl_Index.Name = "ProfilePanel_lbl_Index";
            ProfilePanel_lbl_Index.Size = new Size(12, 15);
            ProfilePanel_lbl_Index.TabIndex = 1;
            ProfilePanel_lbl_Index.Text = "-";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 450);
            Controls.Add(pnl_MealPanel);
            Controls.Add(pnl_ProfilPanel);
            Controls.Add(pnl_ReportsPanel);
            Controls.Add(pnl_LoginPanel);
            Controls.Add(pnl_RegisterPage);
            Controls.Add(pnl_FlowPanel);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diyet Uygulaması";
            pnl_FlowPanel.ResumeLayout(false);
            pnl_MealPanel.ResumeLayout(false);
            MealPanel_gb_FoodEditGroupBox.ResumeLayout(false);
            MealPanel_gb_FoodEditGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MealPanel_nup_PortionSelection).EndInit();
            ((System.ComponentModel.ISupportInitialize)MealPanel_FoodImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)MealPanel_Datagrid).EndInit();
            pnl_LoginPanel.ResumeLayout(false);
            LoginPage_gp_Actions.ResumeLayout(false);
            LoginPage_gp_Actions.PerformLayout();
            pnl_RegisterPage.ResumeLayout(false);
            pnl_RegisterPage.PerformLayout();
            pnl_ProfilPanel.ResumeLayout(false);
            ProfilPanel_gp_Info.ResumeLayout(false);
            ProfilPanel_gp_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_ReportsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ReportsPanel_Datagrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_FlowPanel;
        private Panel pnl_LoginPanel;
        private Button LoginPanel_btn_Register;
        private Button LoginPanel_btn_Entry;
        private TextBox LoginPanel_tb_Password;
        private TextBox LoginPanel_tb_Email;
        private Panel pnl_RegisterPage;
        private Button RegisterPanel_btn_Back;
        private Button RegisterPanel_btn_Register;
        private TextBox RegisterPanel_tb_Password2;
        private TextBox RegisterPanel_tb_Password;
        private TextBox RegisterPanel_tb_Email;
        private Panel pnl_ProfilPanel;
        private Button FlowPanel_btn_Exit;
        private Button FlowPanel_btn_Reports;
        private Button FlowPanel_btn_Meals;
        private Button FlowPanel_btn_Profil;
        private Panel pnl_MealPanel;
        private Button MealPanel_btn_FoodEdit;
        private GroupBox ProfilPanel_gp_Info;
        private PictureBox pictureBox1;
        private Label ProfilPanel_lbl_Concrate2;
        private Label ProfilPanel_lbl_Concrate1;
        private Label ProfilPanel_lbl_Concrate4;
        private Label ProfilPanel_lbl_Concrate3;
        private GroupBox LoginPage_gp_Actions;
        private DataGridView MealPanel_Datagrid;
        private MonthCalendar MealPanel_Calendar;
        private ComboBox MealPanel_cb_FoodSelection;
        private ComboBox MealPanel_cb_MealSelection;
        private PictureBox MealPanel_FoodImage;
        private Panel pnl_ReportsPanel;
        private MonthCalendar ReportsPanel_Calendar;
        private DataGridView ReportsPanel_Datagrid;
        private ComboBox ReportsPanel_cb_QuerySelection;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label ProfilePanel_lbl_Surname;
        private Label ProfilePanel_lbl_Name;
        private Label ProfilePanel_lbl_Password;
        private Label ProfilePanel_lbl_Eposta;
        private ComboBox MealPanel_cb_CatagorySelection;
        private NumericUpDown MealPanel_nup_PortionSelection;
        private Label MealPanel_lbl_MealSelection;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox MealPanel_gb_FoodEditGroupBox;
        private TextBox MealPanel_tb_FoodCalorie;
        private TextBox MealPanel_tb_FoodName;
        private Button MealPanel_btn_FoodDelete;
        private Button MealPanel_btn_FoodUpdate;
        private Button MealPanel_btn_FoodAdd;
        private Label ProfilePanel_lbl_Index;
        private Label ProfilePanel_lbl_Weight;
        private Label ProfilePanel_lbl_Heights;
        private Label ProfilPanel_lbl_Concrate7;
        private Label ProfilPanel_lbl_Concrate6;
        private Label ProfilPanel_lbl_Concrate5;
    }
}