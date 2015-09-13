using System.Windows.Forms;
using SimpleMvpLogin.Model;
using SimpleMvpLogin.Presenter;
using SimpleMvpLogin.View;

namespace SimpleMvpLogin
{
    public partial class FrmLogin : Form,ILoginView
    {
        private readonly LoginPresenter _loginPresenter;
        public FrmLogin()
        {
            InitializeComponent();
            var context = new SimpleMvpContext();
            var model = new LoginModel(context);
            _loginPresenter = new LoginPresenter(this,model);
        }

        public string UserName { get { return txtUserName.Text; } set { txtUserName.Text = value; } }
        public string Password { get { return txtPassword.Text; } set { txtPassword.Text = value; } }
        public bool CanLogin { get; set; }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            _loginPresenter.Login();
            if (!CanLogin)
            {
                MessageBox.Show(@"UserName Or Password Is Wrong!", @"Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(string.Format("Welcome {0} !",txtUserName.Text),@"Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
