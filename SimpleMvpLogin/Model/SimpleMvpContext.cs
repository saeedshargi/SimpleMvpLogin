using System.Data.Entity;

namespace SimpleMvpLogin.Model
{
    public class SimpleMvpContext : DbContext,IUnitOfWork
    {
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        static SimpleMvpContext()
        {
            Database.SetInitializer(new SimpleMvpInitializer());
        }

        public SimpleMvpContext()
            : base("SimpleMvpContext")
        {
            
        }

        public DbSet<Membership> Memberships { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MembershipMap());
        }
    }
}