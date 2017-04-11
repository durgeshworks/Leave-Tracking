using System.Collections.Generic;

namespace Business
{
    public class EmployeeTypes : BaseBusiness, IEmployeeTypes
    {
        private readonly Repository.IEmployeeType _employeeTypeRepo;

        public EmployeeTypes()
        {
            _employeeTypeRepo = new Repository.EmployeeType();
        }

        public IEnumerable<Models.EmployeeType> GetAll()
        {
            return _employeeTypeRepo.SelectAll().ToModel();
        }

        public Models.EmployeeType SelectById(object id)
        {
            return _employeeTypeRepo.SelectById(id).ToModel();
        }

        public void Insert(Models.EmployeeType obj)
        {
            _employeeTypeRepo.Insert(obj.ToEntity());
        }

        public void Update(Models.EmployeeType obj)
        {
            _employeeTypeRepo.Update(obj.ToEntity());

        }
        public void Delete(object id)
        {
            _employeeTypeRepo.Delete(id);

        }
    }
}
