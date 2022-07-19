using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi3.Model;
using WebApi3.Repository;

namespace WebApi3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController (IEmployeeRepository emp)
        {
            _employeeRepository = emp;

        }
        [HttpGet]
        public IActionResult GetEmployee()
        {
            List < EmployeeModel > OB= _employeeRepository.GetEmployees();
            return  Ok(OB);
        }
    }
}
