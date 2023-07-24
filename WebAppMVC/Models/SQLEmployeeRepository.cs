namespace WebAppMVC.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppdbContext context;
        public SQLEmployeeRepository(AppdbContext context)
        {
            this.context = context;
        }
        public Employee AddEmp(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee; 
        }

        public Employee Delete(int Id)
        {
            Employee employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return employee;
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }

        public Employee UpdateEmployee(Employee employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //  context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}