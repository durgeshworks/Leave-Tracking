using System.Collections.Generic;

namespace Business
{
    public interface IEmployee
    {
        IEnumerable<Models.Employee> GetAll();
        Models.Employee SelectById(object id);
        void Insert(Models.Employee obj);
        void Update(Models.Employee obj);
        void Delete(object id);
    }
}
