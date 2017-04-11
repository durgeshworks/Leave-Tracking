using System.Collections.Generic;
using System.Linq;
using Models;

namespace Business
{
    public static class EntityToModelConverter
    {
        public static Models.Leaves ToModel(this DataAccess.Leaves source)
        {
            return new Models.Leaves
            {
                ApprovedById = source.ApprovedById,
                EmployeeId = source.EmployeeId,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                Id = source.Id,
                LeaveTypeId = source.LeaveTypeId
            };
        }
        public static IEnumerable<Models.Leaves> ToModel(this IEnumerable<DataAccess.Leaves> source)
        {
            return source.Select(leave => leave.ToModel()).ToList();
        }
        public static LeaveType ToModel(this DataAccess.LeaveType source)
        {
            return new LeaveType
            {
                TypeId = source.TypeId,
                Description = source.Description
            };
        }
        public static IEnumerable<LeaveType> ToModel(this IEnumerable<DataAccess.LeaveType> source)
        {
            return source.Select(leave => leave.ToModel()).ToList();
        }
        public static Models.Employee ToModel(this DataAccess.Employee source)
        {
            return new Models.Employee
            {
                AvailableLeaves = source.AvailableLeaves,
                EmployeeTypeId = source.EmployeeTypeId,
                Id = source.Id,
                JoinDate = source.JoinDate,
                LeavesPerYear = source.LeavesPerYear,
                Name = source.Name,
                Number = source.Number,
                ReleavedDate = source.ReleavedDate,
                UsedLeaves = source.UsedLeaves
            };
        }
        public static IEnumerable<Models.Employee> ToModel(this IEnumerable<DataAccess.Employee> source)
        {
            return source.Select(leave => leave.ToModel()).ToList();
        }
        public static EmployeeType ToModel(this DataAccess.EmployeeType source)
        {
            return new EmployeeType
            {
                Description = source.Description,
                TypeId = source.TypeId
            };
        }
        public static IEnumerable<EmployeeType> ToModel(this IEnumerable<DataAccess.EmployeeType> source)
        {
            return source.Select(leave => leave.ToModel()).ToList();
        }
    }


}
