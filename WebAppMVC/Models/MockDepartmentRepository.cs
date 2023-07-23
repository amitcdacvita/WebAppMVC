namespace WebAppMVC.Models
{
    public class MockDepartmentRepository : IDepartmentRepository
    {
        private List<Department> _departmentList;

        public MockDepartmentRepository()
        {
            _departmentList = new List<Department>(){
            new Department() { Id = 1, Name = "HR" },
            new Department() { Id = 2, Name = "IT" },
            new Department() { Id = 3, Name = "payroll" },
     };
        }

        public Department AddDept(Department department)
        {
            department.Id = _departmentList.Max(d => d.Id) + 1;
            _departmentList.Add(department);
            return department;
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _departmentList;
        }

        public Department GetDepartment(int id)
        {
            return _departmentList.FirstOrDefault(d => d.Id == id);
        }
    }
}

