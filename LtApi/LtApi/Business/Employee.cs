using System.Collections.Generic;

namespace Business
{
    public class Employee : BaseBusiness, IEmployee
    {
        private readonly Repository.IEmployee _employeeRepo;

        public Employee()
        {
            _employeeRepo = new Repository.Employee();
        }

        public IEnumerable<Models.Employee> GetAll()
        {
            return _employeeRepo.SelectAll().ToModel();
        }

        public Models.Employee SelectById(object id)
        {
            return _employeeRepo.SelectById(id).ToModel();
        }

        public void Insert(Models.Employee obj)
        {
            _employeeRepo.Insert(obj.ToEntity());
        }

        public void Update(Models.Employee obj)
        {
            _employeeRepo.Update(obj.ToEntity());

        }
        public void Delete(object id)
        {
            _employeeRepo.Delete(id);

        }
    }
}
