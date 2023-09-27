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
            mp_btn_Exit = new Button();
            pnl_LoginPage = new Panel();
            lg_btn_Register = new Button();
            lp_btn_Entry = new Button();
            lg_tb_Password = new TextBox();
            lg_tb_Email = new TextBox();
            pnl_RegisterPage = new Panel();
            rp_btn_Back = new Button();
            rp_btn_Register = new Button();
            rp_tb_Password2 = new TextBox();
            rp_tb_Password = new TextBox();
            rp_tb_Email = new TextBox();
            pnl_MainPage = new Panel();
            pnl_FlowPanel.SuspendLayout();
            pnl_LoginPage.SuspendLayout();
            pnl_RegisterPage.SuspendLayout();
            pnl_MainPage.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_FlowPanel
            // 
            pnl_FlowPanel.BackColor = Color.FromArgb(35, 40, 45);
            pnl_FlowPanel.Controls.Add(mp_btn_Exit);
            pnl_FlowPanel.Dock = DockStyle.Left;
            pnl_FlowPanel.Location = new Point(0, 0);
            pnl_FlowPanel.Name = "pnl_FlowPanel";
            pnl_FlowPanel.Size = new Size(210, 450);
            pnl_FlowPanel.TabIndex = 0;
            // 
            // mp_btn_Exit
            // 
            mp_btn_Exit.Location = new Point(28, 413);
            mp_btn_Exit.Name = "mp_btn_Exit";
            mp_btn_Exit.Size = new Size(137, 23);
            mp_btn_Exit.TabIndex = 0;
            mp_btn_Exit.Text = "Çıkış";
            mp_btn_Exit.UseVisualStyleBackColor = true;
            mp_btn_Exit.Click += mp_btn_Exit_Click;
            // 
            // pnl_LoginPage
            // 
            pnl_LoginPage.BackColor = SystemColors.ButtonShadow;
            pnl_LoginPage.Controls.Add(lg_btn_Register);
            pnl_LoginPage.Controls.Add(lp_btn_Entry);
            pnl_LoginPage.Controls.Add(lg_tb_Password);
            pnl_LoginPage.Controls.Add(lg_tb_Email);
            pnl_LoginPage.Dock = DockStyle.Fill;
            pnl_LoginPage.Location = new Point(0, 0);
            pnl_LoginPage.Name = "pnl_LoginPage";
            pnl_LoginPage.Size = new Size(800, 450);
            pnl_LoginPage.TabIndex = 1;
            // 
            // lg_btn_Register
            // 
            lg_btn_Register.Location = new Point(383, 218);
            lg_btn_Register.Name = "lg_btn_Register";
            lg_btn_Register.Size = new Size(100, 23);
            lg_btn_Register.TabIndex = 4;
            lg_btn_Register.Text = "Kayıt Ol";
            lg_btn_Register.UseVisualStyleBackColor = true;
            lg_btn_Register.Click += lg_btn_Register_Click;
            // 
            // lp_btn_Entry
            // 
            lp_btn_Entry.Location = new Point(277, 218);
            lp_btn_Entry.Name = "lp_btn_Entry";
            lp_btn_Entry.Size = new Size(100, 23);
            lp_btn_Entry.TabIndex = 3;
            lp_btn_Entry.Text = "Giriş";
            lp_btn_Entry.UseVisualStyleBackColor = true;
            lp_btn_Entry.Click += lp_btn_Entry_Click;
            // 
            // lg_tb_Password
            // 
            lg_tb_Password.Location = new Point(277, 189);
            lg_tb_Password.Name = "lg_tb_Password";
            lg_tb_Password.PlaceholderText = "Şifre";
            lg_tb_Password.Size = new Size(206, 23);
            lg_tb_Password.TabIndex = 2;
            // 
            // lg_tb_Email
            // 
            lg_tb_Email.Location = new Point(277, 160);
            lg_tb_Email.Name = "lg_tb_Email";
            lg_tb_Email.PlaceholderText = "E-Mail";
            lg_tb_Email.Size = new Size(206, 23);
            lg_tb_Email.TabIndex = 1;
            // 
            // pnl_RegisterPage
            // 
            pnl_RegisterPage.BackColor = SystemColors.ButtonShadow;
            pnl_RegisterPage.Controls.Add(rp_btn_Back);
            pnl_RegisterPage.Controls.Add(rp_btn_Register);
            pnl_RegisterPage.Controls.Add(rp_tb_Password2);
            pnl_RegisterPage.Controls.Add(rp_tb_Password);
            pnl_RegisterPage.Controls.Add(rp_tb_Email);
            pnl_RegisterPage.Dock = DockStyle.Fill;
            pnl_RegisterPage.Enabled = false;
            pnl_RegisterPage.Location = new Point(0, 0);
            pnl_RegisterPage.Name = "pnl_RegisterPage";
            pnl_RegisterPage.Size = new Size(800, 450);
            pnl_RegisterPage.TabIndex = 2;
            // 
            // rp_btn_Back
            // 
            rp_btn_Back.Location = new Point(391, 229);
            rp_btn_Back.Name = "rp_btn_Back";
            rp_btn_Back.Size = new Size(70, 23);
            rp_btn_Back.TabIndex = 5;
            rp_btn_Back.Text = " Geri";
            rp_btn_Back.UseVisualStyleBackColor = true;
            rp_btn_Back.Click += rg_btn_Back_Click;
            // 
            // rp_btn_Register
            // 
            rp_btn_Register.Location = new Point(315, 229);
            rp_btn_Register.Name = "rp_btn_Register";
            rp_btn_Register.Size = new Size(70, 23);
            rp_btn_Register.TabIndex = 4;
            rp_btn_Register.Text = "Kayıt Ol";
            rp_btn_Register.UseVisualStyleBackColor = true;
            rp_btn_Register.Click += rg_btn_Register_Click;
            // 
            // rp_tb_Password2
            // 
            rp_tb_Password2.Location = new Point(315, 200);
            rp_tb_Password2.Name = "rp_tb_Password2";
            rp_tb_Password2.PlaceholderText = "Şifrenizi Tekrardan Giriniz";
            rp_tb_Password2.Size = new Size(146, 23);
            rp_tb_Password2.TabIndex = 3;
            // 
            // rp_tb_Password
            // 
            rp_tb_Password.Location = new Point(315, 171);
            rp_tb_Password.Name = "rp_tb_Password";
            rp_tb_Password.PlaceholderText = "Şifrenizi Giriniz";
            rp_tb_Password.Size = new Size(146, 23);
            rp_tb_Password.TabIndex = 2;
            // 
            // rp_tb_Email
            // 
            rp_tb_Email.Location = new Point(315, 142);
            rp_tb_Email.Name = "rp_tb_Email";
            rp_tb_Email.PlaceholderText = "E-Mailinizi Giriniz";
            rp_tb_Email.Size = new Size(146, 23);
            rp_tb_Email.TabIndex = 1;
            // 
            // pnl_MainPage
            // 
            pnl_MainPage.BackColor = SystemColors.ButtonShadow;
            pnl_MainPage.Controls.Add(pnl_FlowPanel);
            pnl_MainPage.Dock = DockStyle.Fill;
            pnl_MainPage.Location = new Point(0, 0);
            pnl_MainPage.Name = "pnl_MainPage";
            pnl_MainPage.Size = new Size(800, 450);
            pnl_MainPage.TabIndex = 2;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_MainPage);
            Controls.Add(pnl_LoginPage);
            Controls.Add(pnl_RegisterPage);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            pnl_FlowPanel.ResumeLayout(false);
            pnl_LoginPage.ResumeLayout(false);
            pnl_LoginPage.PerformLayout();
            pnl_RegisterPage.ResumeLayout(false);
            pnl_RegisterPage.PerformLayout();
            pnl_MainPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_FlowPanel;
        private Panel pnl_LoginPage;
        private Button lg_btn_Register;
        private Button lp_btn_Entry;
        private TextBox lg_tb_Password;
        private TextBox lg_tb_Email;
        private Panel pnl_RegisterPage;
        private Button rp_btn_Back;
        private Button rp_btn_Register;
        private TextBox rp_tb_Password2;
        private TextBox rp_tb_Password;
        private TextBox rp_tb_Email;
        private Panel pnl_MainPage;
        private Button mp_btn_Exit;
    }
}