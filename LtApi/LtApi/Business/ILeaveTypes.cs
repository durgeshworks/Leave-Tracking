using System.Collections;
using System.Collections.Generic;
using Models;

namespace Business
{
    public interface ILeaveTypes
    {
        IEnumerable<Models.LeaveType> GetAll();

        LeaveType SelectById(object id);

        void Insert(LeaveType obj);

        void Update(LeaveType obj);

        void Delete(object id);
    }
}
