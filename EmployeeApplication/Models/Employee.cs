namespace EmployeeApplication.Models
{
    public class Employee
    {
        public int EmpId { get; set; }

        public string EmpFname { get; set; } = null!;

        public string EmpLname { get; set; } = null!;

        public string EmpAddress { get; set; } = null!;

        public string EmpEmailId { get; set; } = null!;

        public int EmpSalary { get; set; }

        public DateTime CreatedDt { get; set; }

    }
}
