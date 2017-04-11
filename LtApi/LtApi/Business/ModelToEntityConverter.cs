using System.Collections.Generic;
using System.Linq;
using Models;

namespace Business
{
    public static class ModelToEntityConverter
    {
        public static DataAccess.Leaves ToEntity(this Models.Leaves source)
        {
            return new DataAccess.Leaves
            {
                ApprovedById = source.ApprovedById,
                EmployeeId = source.EmployeeId,
                StartDate = source.StartDate,
                EndDate = source.EndDate,
                Id = source.Id,
                LeaveTypeId = source.LeaveTypeId
            };
        }
        public static IEnumerable<DataAccess.Leaves> ToEntity(this IEnumerable<Models.Leaves> source)
        {
            return source.Select(leave => leave.ToEntity()).ToList();
        }
        public static DataAccess.LeaveType ToEntity(this LeaveType source)
        {
            return new DataAccess.LeaveType
            {
                TypeId = source.TypeId,
                Description = source.Description
            };
        }
        public static IEnumerable<DataAccess.LeaveType> ToEntity(this IEnumerable<LeaveType> source)
        {
            return source.Select(leave => leave.ToEntity()).ToList();
        }
        public static DataAccess.Employee ToEntity(this Models.Employee source)
        {
            return new DataAccess.Employee
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
        public static IEnumerable<DataAccess.Employee> ToEntity(this IEnumerable<Models.Employee> source)
        {
            return source.Select(leave => leave.ToEntity()).ToList();
        }
        public static DataAccess.EmployeeType ToEntity(this EmployeeType source)
        {
            return new DataAccess.EmployeeType
            {
                Description = source.Description,
                TypeId = source.TypeId
            };
        }
        public static IEnumerable<DataAccess.EmployeeType> ToEntity(this IEnumerable<EmployeeType> source)
        {
            return source.Select(leave => leave.ToEntity()).ToList();
        }
    }


}
