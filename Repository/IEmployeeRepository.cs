using WebApi3.Model;

namespace WebApi3.Repository
{
    public interface IEmployeeRepository
    {
        List<EmployeeModel> AddEmployee(EmployeeModel employee);
        List<EmployeeModel> GetEmployees();
    }
}
