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
    public partial class RegisterDialog : Form
    {
        public RegisterDialog()
        {
            InitializeComponent();
        }
        LoginPage LoginPageRef;
        private void rd_btn_Register_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void rd_btn_Back_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
