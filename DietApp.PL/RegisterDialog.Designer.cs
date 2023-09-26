namespace DietApp.PL
{
    partial class RegisterDialog
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
            rd_tb_Eposta = new TextBox();
            rd_tb_Password = new TextBox();
            rd_tb_Password2 = new TextBox();
            rd_btn_Register = new Button();
            rd_btn_Back = new Button();
            SuspendLayout();
            // 
            // rd_tb_Eposta
            // 
            rd_tb_Eposta.Location = new Point(26, 12);
            rd_tb_Eposta.Name = "rd_tb_Eposta";
            rd_tb_Eposta.PlaceholderText = "E-Posta Adresinizi Giriniz";
            rd_tb_Eposta.Size = new Size(160, 23);
            rd_tb_Eposta.TabIndex = 1;
            // 
            // rd_tb_Password
            // 
            rd_tb_Password.Location = new Point(26, 41);
            rd_tb_Password.Name = "rd_tb_Password";
            rd_tb_Password.PlaceholderText = "Şifrenizi Giriniz";
            rd_tb_Password.Size = new Size(160, 23);
            rd_tb_Password.TabIndex = 2;
            // 
            // rd_tb_Password2
            // 
            rd_tb_Password2.Location = new Point(26, 70);
            rd_tb_Password2.Name = "rd_tb_Password2";
            rd_tb_Password2.PlaceholderText = "Şifrenizi Yeniden Giriniz";
            rd_tb_Password2.Size = new Size(160, 23);
            rd_tb_Password2.TabIndex = 3;
            // 
            // rd_btn_Register
            // 
            rd_btn_Register.Location = new Point(26, 99);
            rd_btn_Register.Name = "rd_btn_Register";
            rd_btn_Register.Size = new Size(75, 23);
            rd_btn_Register.TabIndex = 4;
            rd_btn_Register.Text = "Kayıt Ol";
            rd_btn_Register.UseVisualStyleBackColor = true;
            rd_btn_Register.Click += rd_btn_Register_Click;
            // 
            // rd_btn_Back
            // 
            rd_btn_Back.Location = new Point(107, 99);
            rd_btn_Back.Name = "rd_btn_Back";
            rd_btn_Back.Size = new Size(75, 23);
            rd_btn_Back.TabIndex = 5;
            rd_btn_Back.Text = "Geri";
            rd_btn_Back.UseVisualStyleBackColor = true;
            rd_btn_Back.Click += rd_btn_Back_Click;
            // 
            // RegisterDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 133);
            Controls.Add(rd_btn_Back);
            Controls.Add(rd_btn_Register);
            Controls.Add(rd_tb_Password2);
            Controls.Add(rd_tb_Password);
            Controls.Add(rd_tb_Eposta);
            Name = "RegisterDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox rd_tb_Eposta;
        private TextBox rd_tb_Password;
        private TextBox rd_tb_Password2;
        private Button rd_btn_Register;
        private Button rd_btn_Back;
    }
}