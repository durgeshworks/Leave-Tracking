using System.Collections.Generic;
using System.Web.Http;
using Business;
using Models;

namespace LtApi.Controllers
{
    public class LeaveTypesController : ApiController
    {
        readonly ILeaveTypes _leaveTypesBusiness = new LeaveTypes();

        public IEnumerable<LeaveType> Get()
        {
            return _leaveTypesBusiness.GetAll();
        }

       // GET api/values/5
        public LeaveType Get(int id)
        {
            return _leaveTypesBusiness.SelectById(id);
        }

        // POST api/values
        public void Post(LeaveType value)
        {
            _leaveTypesBusiness.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, LeaveType value)
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
