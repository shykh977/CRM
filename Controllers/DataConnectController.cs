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
    public class DataConnectController : ControllerBase
    {
        private IGenericRepository<Quries> _IgenericRepository;

        DbDataGateway dbDataGateway = null;

        public DataConnectController(IGenericRepository<Quries> igenericRepository)
        {
            dbDataGateway = new DbDataGateway(igenericRepository);
        }

        [HttpPost]
        [Route("ExecuteQuery")]
        public IActionResult ExecuteQuery(Quries quries)
        {
            return Ok(dbDataGateway.ExecuteQuery(quries));
        }
    }
}
