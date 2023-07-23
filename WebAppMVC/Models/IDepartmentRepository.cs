namespace WebAppMVC.Models
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartment();

        Department GetDepartment(int id);

        Department AddDept(Department department);
    }
}
