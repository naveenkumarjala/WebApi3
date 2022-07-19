using WebApi3.DBContext;
using WebApi3.Model;

namespace WebApi3.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext db;

        public EmployeeRepository(EmployeeDbContext db)
        {
            this.db = db;
        }
        public List<EmployeeModel> AddEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public List<EmployeeModel> GetEmployees()
        {
            return db.Employee.ToList();
        }
    }
}
