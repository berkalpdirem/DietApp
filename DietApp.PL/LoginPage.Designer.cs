namespace DietApp.PL
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_Interaction = new GroupBox();
            lp_btn_Register = new Button();
            lp_tb_Eposta = new TextBox();
            lp_btn_Entry = new Button();
            lp_tb_Password = new TextBox();
            gb_Interaction.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Interaction
            // 
            gb_Interaction.Controls.Add(lp_btn_Register);
            gb_Interaction.Controls.Add(lp_tb_Eposta);
            gb_Interaction.Controls.Add(lp_btn_Entry);
            gb_Interaction.Controls.Add(lp_tb_Password);
            gb_Interaction.Location = new Point(276, 336);
            gb_Interaction.Name = "gb_Interaction";
            gb_Interaction.Size = new Size(196, 113);
            gb_Interaction.TabIndex = 2;
            gb_Interaction.TabStop = false;
            // 
            // lp_btn_Register
            // 
            lp_btn_Register.Location = new Point(102, 73);
            lp_btn_Register.Name = "lp_btn_Register";
            lp_btn_Register.Size = new Size(75, 23);
            lp_btn_Register.TabIndex = 4;
            lp_btn_Register.Text = "Kayıt Ol";
            lp_btn_Register.UseVisualStyleBackColor = true;
            lp_btn_Register.Click += lp_btn_Register_Click;
            // 
            // lp_tb_Eposta
            // 
            lp_tb_Eposta.Location = new Point(20, 15);
            lp_tb_Eposta.Name = "lp_tb_Eposta";
            lp_tb_Eposta.PlaceholderText = "E-Posta Adresiniz";
            lp_tb_Eposta.Size = new Size(160, 23);
            lp_tb_Eposta.TabIndex = 1;
            // 
            // lp_btn_Entry
            // 
            lp_btn_Entry.Location = new Point(20, 73);
            lp_btn_Entry.Name = "lp_btn_Entry";
            lp_btn_Entry.Size = new Size(75, 23);
            lp_btn_Entry.TabIndex = 3;
            lp_btn_Entry.Text = "Giriş";
            lp_btn_Entry.UseVisualStyleBackColor = true;
            lp_btn_Entry.Click += lp_btn_Entry_Click;
            // 
            // lp_tb_Password
            // 
            lp_tb_Password.Location = new Point(20, 44);
            lp_tb_Password.Name = "lp_tb_Password";
            lp_tb_Password.PlaceholderText = "Şifre";
            lp_tb_Password.Size = new Size(160, 23);
            lp_tb_Password.TabIndex = 2;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(gb_Interaction);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += LoginPage_Load;
            gb_Interaction.ResumeLayout(false);
            gb_Interaction.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Interaction;
        private Button lp_btn_Register;
        private TextBox lp_tb_Eposta;
        private Button lp_btn_Entry;
        private TextBox lp_tb_Password;
    }
}