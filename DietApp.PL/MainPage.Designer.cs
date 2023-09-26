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
            button1 = new Button();
            mp_btn_ListMeals = new Button();
            mp_btn_DetailReports = new Button();
            dataGridView = new DataGridView();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            mp_rb_Add = new RadioButton();
            mp_rb_Update = new RadioButton();
            mp_rb_Delete = new RadioButton();
            mp_nup_Portion = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mp_nup_Portion).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(357, 35);
            button1.Name = "button1";
            button1.Size = new Size(161, 23);
            button1.TabIndex = 0;
            button1.Text = "Listele";
            button1.UseVisualStyleBackColor = true;
            // 
            // mp_btn_ListMeals
            // 
            mp_btn_ListMeals.Location = new Point(12, 280);
            mp_btn_ListMeals.Name = "mp_btn_ListMeals";
            mp_btn_ListMeals.Size = new Size(120, 40);
            mp_btn_ListMeals.TabIndex = 0;
            mp_btn_ListMeals.Text = "Öğünlerimi Listele";
            mp_btn_ListMeals.UseVisualStyleBackColor = true;
            // 
            // mp_btn_DetailReports
            // 
            mp_btn_DetailReports.Location = new Point(12, 335);
            mp_btn_DetailReports.Name = "mp_btn_DetailReports";
            mp_btn_DetailReports.Size = new Size(120, 40);
            mp_btn_DetailReports.TabIndex = 0;
            mp_btn_DetailReports.Text = "Detaylı Raporlar";
            mp_btn_DetailReports.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(145, 89);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(377, 282);
            dataGridView.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(357, 59);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(251, 59);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 23);
            comboBox3.TabIndex = 2;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(145, 60);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(100, 23);
            comboBox4.TabIndex = 2;
            comboBox4.Text = "Numara";
            // 
            // mp_rb_Add
            // 
            mp_rb_Add.AutoSize = true;
            mp_rb_Add.Location = new Point(145, 35);
            mp_rb_Add.Name = "mp_rb_Add";
            mp_rb_Add.Size = new Size(46, 19);
            mp_rb_Add.TabIndex = 3;
            mp_rb_Add.TabStop = true;
            mp_rb_Add.Text = "Ekle";
            mp_rb_Add.UseVisualStyleBackColor = true;
            // 
            // mp_rb_Update
            // 
            mp_rb_Update.AutoSize = true;
            mp_rb_Update.Location = new Point(197, 35);
            mp_rb_Update.Name = "mp_rb_Update";
            mp_rb_Update.Size = new Size(71, 19);
            mp_rb_Update.TabIndex = 3;
            mp_rb_Update.TabStop = true;
            mp_rb_Update.Text = "Güncelle";
            mp_rb_Update.UseVisualStyleBackColor = true;
            // 
            // mp_rb_Delete
            // 
            mp_rb_Delete.AutoSize = true;
            mp_rb_Delete.Location = new Point(274, 35);
            mp_rb_Delete.Name = "mp_rb_Delete";
            mp_rb_Delete.Size = new Size(37, 19);
            mp_rb_Delete.TabIndex = 3;
            mp_rb_Delete.TabStop = true;
            mp_rb_Delete.Text = "Sil";
            mp_rb_Delete.UseVisualStyleBackColor = true;
            // 
            // mp_nup_Portion
            // 
            mp_nup_Portion.DecimalPlaces = 1;
            mp_nup_Portion.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            mp_nup_Portion.Location = new Point(463, 60);
            mp_nup_Portion.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            mp_nup_Portion.Name = "mp_nup_Portion";
            mp_nup_Portion.Size = new Size(59, 23);
            mp_nup_Portion.TabIndex = 4;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 379);
            Controls.Add(mp_nup_Portion);
            Controls.Add(mp_rb_Delete);
            Controls.Add(mp_rb_Update);
            Controls.Add(mp_rb_Add);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(dataGridView);
            Controls.Add(mp_btn_DetailReports);
            Controls.Add(mp_btn_ListMeals);
            Controls.Add(button1);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            FormClosed += MainPage_FormClosed;
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)mp_nup_Portion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button mp_btn_UserProfile;
        private Button button1;
        private Button mp_btn_ListMeals;
        private Button mp_btn_DetailReports;
        private DataGridView dataGridView;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private RadioButton mp_rb_Add;
        private RadioButton mp_rb_Update;
        private RadioButton mp_rb_Delete;
        private NumericUpDown mp_nup_Portion;
    }
}