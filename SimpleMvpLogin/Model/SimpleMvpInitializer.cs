using System.Data.Entity;

namespace SimpleMvpLogin.Model
{
    public class SimpleMvpInitializer : CreateDatabaseIfNotExists<SimpleMvpContext>
    {
        protected override void Seed(SimpleMvpContext context)
        {
            context.Memberships.Add(new Membership
            {
                UserName = "admin",
                Password = "123456"
            });
            base.Seed(context);
        }
    }
}