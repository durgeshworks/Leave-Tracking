using System.Collections.Generic;

namespace Business
{
    public interface IEmployeeTypes
    {
        IEnumerable<Models.EmployeeType> GetAll();

        Models.EmployeeType SelectById(object id);

        void Insert(Models.EmployeeType obj);

        void Update(Models.EmployeeType obj);

        void Delete(object id);
    }
}
