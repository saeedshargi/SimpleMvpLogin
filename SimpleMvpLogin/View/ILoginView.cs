namespace SimpleMvpLogin.View
{
    public interface ILoginView
    {
        string UserName { get; set; }
        string Password { get; set; }
        bool CanLogin { get; set; }
    }
}