using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Business;

namespace LtApi.Controllers
{
    public class EmployeeTypesController : ApiController
    {
        readonly IEmployeeTypes _leaveTypesBusiness = new EmployeeTypes();

        public IEnumerable<Models.EmployeeType> Get()
        {
            return _leaveTypesBusiness.GetAll();
        }

        // GET api/values/5
        public Models.EmployeeType Get(int id)
        {
            return _leaveTypesBusiness.SelectById(id);
        }

        // POST api/values
        public void Post(Models.EmployeeType value)
        {
            _leaveTypesBusiness.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, Models.EmployeeType value)
        {
            _leaveTypesBusiness.Update(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _leaveTypesBusiness.Delete(id);
        }

    }
}
