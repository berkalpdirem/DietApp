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
            MealPanel_FoodImage = new PictureBox();
            MealPanel_cb_PortionSelection = new ComboBox();
            MealPanel_cb_FoodSelection = new ComboBox();
            MealPanel_cb_MealSelection = new ComboBox();
            MealPanel_Calendar = new MonthCalendar();
            MealPanel_Datagrid = new DataGridView();
            MealPanel_btn_MealRemove = new Button();
            MealPanel_btn_MealUpdate = new Button();
            MealPanel_btn_MealAdd = new Button();
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
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnl_ReportsPanel = new Panel();
            ReportsPanel_Calendar = new MonthCalendar();
            ReportsPanel_Datagrid = new DataGridView();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            ReportsPanel_cb_QuerySelection = new ComboBox();
            pnl_FlowPanel.SuspendLayout();
            pnl_MealPanel.SuspendLayout();
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
            pnl_MealPanel.Controls.Add(MealPanel_FoodImage);
            pnl_MealPanel.Controls.Add(MealPanel_cb_PortionSelection);
            pnl_MealPanel.Controls.Add(MealPanel_cb_FoodSelection);
            pnl_MealPanel.Controls.Add(MealPanel_cb_MealSelection);
            pnl_MealPanel.Controls.Add(MealPanel_Calendar);
            pnl_MealPanel.Controls.Add(MealPanel_Datagrid);
            pnl_MealPanel.Controls.Add(MealPanel_btn_MealRemove);
            pnl_MealPanel.Controls.Add(MealPanel_btn_MealUpdate);
            pnl_MealPanel.Controls.Add(MealPanel_btn_MealAdd);
            pnl_MealPanel.Dock = DockStyle.Fill;
            pnl_MealPanel.Location = new Point(210, 0);
            pnl_MealPanel.Name = "pnl_MealPanel";
            pnl_MealPanel.Size = new Size(627, 450);
            pnl_MealPanel.TabIndex = 2;
            // 
            // MealPanel_FoodImage
            // 
            MealPanel_FoodImage.Image = Properties.Resources.YemekFoto;
            MealPanel_FoodImage.Location = new Point(259, 12);
            MealPanel_FoodImage.Name = "MealPanel_FoodImage";
            MealPanel_FoodImage.Size = new Size(129, 146);
            MealPanel_FoodImage.SizeMode = PictureBoxSizeMode.StretchImage;
            MealPanel_FoodImage.TabIndex = 4;
            MealPanel_FoodImage.TabStop = false;
            // 
            // MealPanel_cb_PortionSelection
            // 
            MealPanel_cb_PortionSelection.FormattingEnabled = true;
            MealPanel_cb_PortionSelection.Location = new Point(116, 68);
            MealPanel_cb_PortionSelection.Name = "MealPanel_cb_PortionSelection";
            MealPanel_cb_PortionSelection.Size = new Size(137, 23);
            MealPanel_cb_PortionSelection.TabIndex = 3;
            MealPanel_cb_PortionSelection.Text = "Porsiyon'unuzu Seçiniz";
            // 
            // MealPanel_cb_FoodSelection
            // 
            MealPanel_cb_FoodSelection.FormattingEnabled = true;
            MealPanel_cb_FoodSelection.Location = new Point(116, 42);
            MealPanel_cb_FoodSelection.Name = "MealPanel_cb_FoodSelection";
            MealPanel_cb_FoodSelection.Size = new Size(137, 23);
            MealPanel_cb_FoodSelection.TabIndex = 3;
            MealPanel_cb_FoodSelection.Text = "Yemek İsmini Seçiniz";
            // 
            // MealPanel_cb_MealSelection
            // 
            MealPanel_cb_MealSelection.FormattingEnabled = true;
            MealPanel_cb_MealSelection.Location = new Point(116, 13);
            MealPanel_cb_MealSelection.Name = "MealPanel_cb_MealSelection";
            MealPanel_cb_MealSelection.Size = new Size(137, 23);
            MealPanel_cb_MealSelection.TabIndex = 3;
            MealPanel_cb_MealSelection.Text = "Öğünüzü Seçiniz";
            // 
            // MealPanel_Calendar
            // 
            MealPanel_Calendar.Location = new Point(400, 0);
            MealPanel_Calendar.MaxDate = new DateTime(2023, 9, 27, 0, 0, 0, 0);
            MealPanel_Calendar.Name = "MealPanel_Calendar";
            MealPanel_Calendar.TabIndex = 2;
            // 
            // MealPanel_Datagrid
            // 
            MealPanel_Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MealPanel_Datagrid.Location = new Point(0, 164);
            MealPanel_Datagrid.Name = "MealPanel_Datagrid";
            MealPanel_Datagrid.RowTemplate.Height = 25;
            MealPanel_Datagrid.Size = new Size(627, 286);
            MealPanel_Datagrid.TabIndex = 1;
            // 
            // MealPanel_btn_MealRemove
            // 
            MealPanel_btn_MealRemove.Location = new Point(6, 96);
            MealPanel_btn_MealRemove.Name = "MealPanel_btn_MealRemove";
            MealPanel_btn_MealRemove.Size = new Size(88, 23);
            MealPanel_btn_MealRemove.TabIndex = 0;
            MealPanel_btn_MealRemove.Text = "Öğün Sil";
            MealPanel_btn_MealRemove.UseVisualStyleBackColor = true;
            // 
            // MealPanel_btn_MealUpdate
            // 
            MealPanel_btn_MealUpdate.Location = new Point(6, 54);
            MealPanel_btn_MealUpdate.Name = "MealPanel_btn_MealUpdate";
            MealPanel_btn_MealUpdate.Size = new Size(88, 23);
            MealPanel_btn_MealUpdate.TabIndex = 0;
            MealPanel_btn_MealUpdate.Text = "Öğün Düzenle";
            MealPanel_btn_MealUpdate.UseVisualStyleBackColor = true;
            // 
            // MealPanel_btn_MealAdd
            // 
            MealPanel_btn_MealAdd.Location = new Point(6, 12);
            MealPanel_btn_MealAdd.Name = "MealPanel_btn_MealAdd";
            MealPanel_btn_MealAdd.Size = new Size(88, 23);
            MealPanel_btn_MealAdd.TabIndex = 0;
            MealPanel_btn_MealAdd.Text = "Öğün Ekle";
            MealPanel_btn_MealAdd.UseVisualStyleBackColor = true;
            // 
            // pnl_LoginPanel
            // 
            pnl_LoginPanel.BackColor = SystemColors.ButtonShadow;
            pnl_LoginPanel.Controls.Add(LoginPage_gp_Actions);
            pnl_LoginPanel.Dock = DockStyle.Fill;
            pnl_LoginPanel.Location = new Point(210, 0);
            pnl_LoginPanel.Name = "pnl_LoginPanel";
            pnl_LoginPanel.Size = new Size(627, 450);
            pnl_LoginPanel.TabIndex = 1;
            pnl_LoginPanel.Paint += pnl_LoginPanel_Paint;
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
            pnl_RegisterPage.Location = new Point(0, 0);
            pnl_RegisterPage.Name = "pnl_RegisterPage";
            pnl_RegisterPage.Size = new Size(837, 450);
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
            pnl_ProfilPanel.Size = new Size(627, 450);
            pnl_ProfilPanel.TabIndex = 2;
            // 
            // ProfilPanel_gp_Info
            // 
            ProfilPanel_gp_Info.Controls.Add(pictureBox1);
            ProfilPanel_gp_Info.Controls.Add(label4);
            ProfilPanel_gp_Info.Controls.Add(label1);
            ProfilPanel_gp_Info.Controls.Add(label3);
            ProfilPanel_gp_Info.Controls.Add(label2);
            ProfilPanel_gp_Info.Location = new Point(181, 32);
            ProfilPanel_gp_Info.Name = "ProfilPanel_gp_Info";
            ProfilPanel_gp_Info.Size = new Size(256, 220);
            ProfilPanel_gp_Info.TabIndex = 2;
            ProfilPanel_gp_Info.TabStop = false;
            ProfilPanel_gp_Info.Text = "Profil Bilgileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(94, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 80);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 145);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 1;
            label4.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 122);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "E-Posta :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 188);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 1;
            label3.Text = "Soy İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 165);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "İsim:";
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
            pnl_ReportsPanel.Size = new Size(627, 450);
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
            ReportsPanel_Datagrid.Location = new Point(0, 164);
            ReportsPanel_Datagrid.Name = "ReportsPanel_Datagrid";
            ReportsPanel_Datagrid.RowTemplate.Height = 25;
            ReportsPanel_Datagrid.Size = new Size(627, 286);
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
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 450);
            Controls.Add(pnl_LoginPanel);
            Controls.Add(pnl_ReportsPanel);
            Controls.Add(pnl_MealPanel);
            Controls.Add(pnl_ProfilPanel);
            Controls.Add(pnl_FlowPanel);
            Controls.Add(pnl_RegisterPage);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diyet Uygulaması";
            pnl_FlowPanel.ResumeLayout(false);
            pnl_MealPanel.ResumeLayout(false);
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
        private Button MealPanel_btn_MealRemove;
        private Button MealPanel_btn_MealUpdate;
        private Button MealPanel_btn_MealAdd;
        private GroupBox ProfilPanel_gp_Info;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox LoginPage_gp_Actions;
        private DataGridView MealPanel_Datagrid;
        private MonthCalendar MealPanel_Calendar;
        private ComboBox MealPanel_cb_PortionSelection;
        private ComboBox MealPanel_cb_FoodSelection;
        private ComboBox MealPanel_cb_MealSelection;
        private PictureBox MealPanel_FoodImage;
        private Panel pnl_ReportsPanel;
        private MonthCalendar ReportsPanel_Calendar;
        private DataGridView ReportsPanel_Datagrid;
        private ComboBox ReportsPanel_cb_QuerySelection;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}