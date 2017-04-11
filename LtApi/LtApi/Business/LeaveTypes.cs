using System.Collections.Generic;
using Models;

namespace Business
{
    public class LeaveTypes : BaseBusiness, ILeaveTypes
    {
        private readonly Repository.ILeaveTypes _leaveTypesRepo;

        public LeaveTypes()
        {
            _leaveTypesRepo = new Repository.LeaveTypes();
        }

        public IEnumerable<LeaveType> GetAll()
        {
            return _leaveTypesRepo.SelectAll().ToModel();
        }

        public LeaveType SelectById(object id)
        {
            return _leaveTypesRepo.SelectById(id).ToModel();
        }

        public void Insert(LeaveType obj)
        {
            _leaveTypesRepo.Insert(obj.ToEntity());
        }

        public void Update(LeaveType obj)
        {
            _leaveTypesRepo.Update(obj.ToEntity());

        }

        public void Delete(object id)
        {
            _leaveTypesRepo.Delete(id);

        }
    }
}
