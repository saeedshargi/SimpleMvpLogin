using System.Data.Entity;

namespace SimpleMvpLogin.Model
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}