using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BTG_CRM.DbConnect;
using BTG_CRM.Model;
using BTG_CRM.Common;
using BTG_CRM.DataLayer;

namespace BTG_CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private IGenericRepository<Departments> _IgenericRepository;

        UsersService usersService  = null;

        public DepartmentsController(IGenericRepository<Departments> igenericRepository)
        {
            usersService = new UsersService(igenericRepository);
        }

        [HttpPost]
        [Route("CreateDepartments")]
        public IActionResult CreateDepartments(Departments departments )
        {
            return Ok(usersService.CreateDepartments(departments));
        }
        
        
        [HttpPost]
        [Route("GetDepartments")]
        public IActionResult GetDepartments(Departments departments )
        {
            return Ok(usersService.GetDepartments(departments));
        }
        
        [HttpPost]
        [Route("LoginUser")]
        public IActionResult LoginUser(UserLogin userLogin  )
        {
            return Ok(usersService.LoginUser(userLogin));
        }
        
        [HttpPost]
        [Route("CreateCrmUsers")]
        public IActionResult CreateCrmUsers(CrmUsers crmUsers  )
        {
            return Ok(usersService.CreateCrmUsers(crmUsers));
        }
        
        [HttpPost]
        [Route("GetCrmUser")]
        public IActionResult GetCrmUser(CrmUsers crmUsers  )
        {
            return Ok(usersService.GetCrmUser(crmUsers));
        }
        
        [HttpPost]
        [Route("GetCrmUserById")]
        public IActionResult GetCrmUserById(CrmUsers crmUsers  )
        {
            return Ok(usersService.GetCrmUserById(crmUsers));
        } 
        
        
        [HttpPost]
        [Route("GetCrmUserAll")]
        public IActionResult GetCrmUserAll(Departments crmUsers  )
        {
            return Ok(usersService.GetCrmUserAll(crmUsers));
        }
    }
}
