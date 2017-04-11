using System.Collections.Generic;
using System.Web.Http;
using Business;
using Leaves = Models.Leaves;

namespace LtApi.Controllers
{
    public class LeavesController : ApiController
    {
        readonly ILeaves _leavesBusiness = new Business.Leaves();

        // GET api/values
        public IEnumerable<Leaves> Get()
        {
            return _leavesBusiness.GetAll();
        }

        // GET api/values/5
        public Leaves Get(int id)
        {
            return _leavesBusiness.SelectById(id);
        }

        // POST api/values
        public void Post(Leaves value)
        {
            _leavesBusiness.Insert(value);
        }

        // PUT api/values/5
        public void Put(int id, Leaves value)
        {
            _leavesBusiness.Update(value);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _leavesBusiness.Delete(id);
        }
    }
}
