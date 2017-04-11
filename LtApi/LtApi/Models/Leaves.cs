namespace Models
{
    public class Leaves : BaseModel
    {
        public int Id { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int LeaveTypeId { get; set; }
        public int EmployeeId { get; set; }
        public int ApprovedById { get; set; }
    }
}
