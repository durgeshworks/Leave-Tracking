//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Leaves = new HashSet<Leaves>();
            this.Leaves1 = new HashSet<Leaves>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeTypeId { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<System.DateTime> ReleavedDate { get; set; }
        public string Number { get; set; }
        public int LeavesPerYear { get; set; }
        public int UsedLeaves { get; set; }
        public int AvailableLeaves { get; set; }
    
        public virtual ICollection<Leaves> Leaves { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual ICollection<Leaves> Leaves1 { get; set; }
    }
}
