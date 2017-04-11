namespace Models
{
    using System;

    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeTypeId { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? ReleavedDate { get; set; }
        public string Number { get; set; }
        public int LeavesPerYear { get; set; }
        public int UsedLeaves { get; set; }
        public int AvailableLeaves { get; set; }
    }
}
