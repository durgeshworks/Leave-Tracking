using System;
using System.Collections.Generic;

namespace Business
{
    public class Leaves : BaseBusiness, ILeaves
    {
        private readonly Repository.ILeaves _leavesRepo;

        public Leaves()
        {
            _leavesRepo = new Repository.Leaves();
        }

        public IEnumerable<Models.Leaves> GetAll()
        {
            return _leavesRepo.SelectAll().ToModel();
        }

        public Models.Leaves SelectById(object id)
        {
            return _leavesRepo.SelectById(id).ToModel();
        }

        public void Insert(Models.Leaves obj)
        {
            _leavesRepo.Insert(obj.ToEntity());
        }

        public void Update(Models.Leaves obj)
        {
            _leavesRepo.Update(obj.ToEntity());

        }

        public void Delete(object id)
        {
            _leavesRepo.Delete(id);

        }

        public IEnumerable<Models.Leaves> GetLeaveTrackerDetailsForGivenDateRange(DateTime startDate, DateTime endDate)
        {
            return _leavesRepo.SelectAll().ToModel();
        }


    }
}
