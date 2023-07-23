namespace WebAppMVC.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployee();

        Employee GetEmployee(int id);

        Employee AddEmp (Employee employee);
    }
}
