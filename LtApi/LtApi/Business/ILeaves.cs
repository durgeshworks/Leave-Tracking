using System;
using System.Collections.Generic;

namespace Business
{
    public interface ILeaves
    {
        IEnumerable<Models.Leaves> GetLeaveTrackerDetailsForGivenDateRange(DateTime startDate, DateTime endDate);
        IEnumerable<Models.Leaves> GetAll();
        Models.Leaves SelectById(object id);
        void Insert(Models.Leaves obj);
        void Update(Models.Leaves obj);
        void Delete(object id);
    }
}
