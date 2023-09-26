namespace DietApp.PL
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            LoginPageRef = this;
        }
        public LoginPage LoginPageRef;
        public MainPage MainPageRef;


        private void lp_btn_Entry_Click(object sender, EventArgs e)
        {
            if (lp_tb_Eposta.Text == "alp" && lp_tb_Password.Text == "alp123")
            {
                MainPageRef = new MainPage();
                MainPageRef.Show();
                this.Visible = false;

            }
        }

        private void lp_btn_Register_Click(object sender, EventArgs e)
        {
            RegisterDialog RegisterDialogRef = new RegisterDialog();
            RegisterDialogRef.ShowDialog();

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}