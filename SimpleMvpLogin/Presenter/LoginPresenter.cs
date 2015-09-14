using SimpleMvpLogin.Model;
using SimpleMvpLogin.View;

namespace SimpleMvpLogin.Presenter
{
    public class LoginPresenter
    {
        private readonly ILoginView _loginView;
        private readonly ILoginModel _loginModel;

        public LoginPresenter(ILoginView loginView, ILoginModel loginModel)
        {
            _loginView = loginView;
            _loginModel = loginModel;
        }

        public bool ControlsInputs()
        {
            if (string.IsNullOrEmpty(_loginView.UserName))
            {
                return false;
            }
            if (string.IsNullOrEmpty(_loginView.Password))
            {
                return false;
            }
            return true;
        }

        public bool ValidateInputs()
        {
            if (_loginView.Password.Length < 6)
            {
                return false;
            }
            return true;
        }

        public void Login()
        {
            if (!ControlsInputs())
            {
                _loginView.CanLogin = false;
                return;
            }
            if (!ValidateInputs())
            {
                _loginView.CanLogin = false;
                return;
            }
            _loginView.CanLogin = _loginModel.IsLoginValid(_loginView.UserName, _loginView.Password);
        }
    }
}