namespace SimpleMvpLogin.Model
{
    public interface ILoginModel
    {
        bool IsLoginValid(string userName, string password);
    }
}