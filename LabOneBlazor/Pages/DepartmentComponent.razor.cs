using LabOneBlazor.Models;

namespace LabOneBlazor.Pages
{
    public partial class DepartmentComponent
    {
        public List<Department> Departments { get; set; }
        public int deptId { get; set; }
        public Department Department{ get; set; }
        public DepartmentComponent()
        {
            //Department = new Department()
            //{
            //    Id = 10,
            //    Name = "SD",
            //    Description = "System Development"
            //};

            Departments = new List<Department>();
            Departments.Add(new Department() { Id = 10, Name = "SD", Description = "System Development" });
            Departments.Add(new Department() { Id = 20, Name = "HR", Description = "Human Resources" });
            Departments.Add(new Department() { Id = 30, Name = "IT", Description = "Information Technology" });
            Departments.Add(new Department() { Id = 40, Name = "FIN", Description = "Finance" });
            Departments.Add(new Department() { Id = 50, Name = "MKT", Description = "Marketing" });
            Departments.Add(new Department() { Id = 60, Name = "QA", Description = "Quality Assurance" });
            Departments.Add(new Department() { Id = 70, Name = "RD", Description = "Research and Development" });
            Departments.Add(new Department() { Id = 80, Name = "PR", Description = "Public Relations" });
            Departments.Add(new Department() { Id = 90, Name = "CS", Description = "Customer Support" });
            Departments.Add(new Department() { Id = 100, Name = "OPS", Description = "Operations" });







        }


        void GetDept()
        {
            if (deptId != 0)
            {
                Department = Departments.FirstOrDefault(dept => dept.Id == deptId);
            }
        }
    }
}
