using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccess;


namespace Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly LeaveTrackerDbContext _dbContext;
        private readonly DbSet<T> _table;

        public BaseRepository(LeaveTrackerDbContext db)
        {
            _dbContext = db;
            _table = db.Set<T>();
        }

        public BaseRepository()
            : this(new LeaveTrackerDbContext())
        {}

        public IEnumerable<T> SelectAll()
        {
            return _table.ToList();
        }

        public T SelectById(object id)
        {
            return _table.Find(id);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _dbContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
