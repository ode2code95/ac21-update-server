using System.Linq;

namespace RestEntry.Repo
{
    public interface IRepository<T> where T : class, Model.IEntity
    {
        void Create(T e);
        void Delete(int id);
        IQueryable<T> Get();
        void Update(T e);
    }
}
