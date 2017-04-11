using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccess;


namespace Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly LeaveTrackerDbContext DbContext;
        protected readonly DbSet<T> Table;

        public BaseRepository(LeaveTrackerDbContext db)
        {
            DbContext = db;
            Table = db.Set<T>();
        }

        public BaseRepository()
            : this(new LeaveTrackerDbContext())
        {}

        public IEnumerable<T> SelectAll()
        {
            return Table.ToList();
        }

        public T SelectById(object id)
        {
            return Table.Find(id);
        }

        public void Insert(T obj)
        {
            Table.Add(obj);
        }

        public void Update(T obj)
        {
            Table.Attach(obj);
            DbContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = Table.Find(id);
            Table.Remove(existing);
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

    }
}
