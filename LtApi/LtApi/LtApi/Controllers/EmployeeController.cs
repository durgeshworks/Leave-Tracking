using System.Collections.Generic;
using System.Web.Http;
using Business;
using Employee = Business.Employee;

namespace LtApi.Controllers
{
    public class EmployeeController : ApiController
    {
        readonly IEmployee _employeeBusiness = new Employee();

        public IEnumerable<Models.Employee> Get()
        {
            return _employeeBusiness.GetAll();
        }

        // GET api/values/5
        public Models.Employee Get(int id)
        {
            return _employeeBusiness.SelectById(id);
        }

        // POST api/values
        public void Post(Models.Employee value)
        {
            _employeeBusiness.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, Models.Employee value)
        {
            _employeeBusiness.Update(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _employeeBusiness.Delete(id);
        }

    }
}
