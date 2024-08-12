using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BTG_CRM.DbConnect;
using BTG_CRM.Model;
using BTG_CRM.Common;
using BTG_CRM.DataLayer;
using BTG_CRM.Model.ViewModel;

namespace BTG_CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {

        private IGenericRepository<Leads> _IgenericRepository;

        LeadsService leadsService  = null;

        public LeadController(IGenericRepository<Leads> igenericRepository)
        {
            leadsService = new LeadsService(igenericRepository);
        }


        [HttpPost]
        [Route("CreateLeads")]
        public IActionResult CreateLeads(Leads leads)
        {
            return Ok(leadsService.CreateLeads(leads));
        }

        [HttpPost]
        [Route("GetLeadsFilter")]
        public IActionResult GetLeadsFilter(LeadsFilter leads)
        {
            return Ok(leadsService.GetLeadsFilter(leads));
        }


        [HttpPost]
        [Route("CreateLeadDetail")]
        public IActionResult CreateLeadDetail(LeadsDetail leads)
        {
            return Ok(leadsService.CreateLeadDetail(leads));
        }
        
        [HttpPost]
        [Route("GetleadDetails")]
        public IActionResult GetleadDetails(LeadsDetail leads)
        {
            return Ok(leadsService.GetleadDetails(leads));
        }
         
        [HttpPost]
        [Route("GetleadDetailsByAssignedtoo")]
        public IActionResult GetleadDetailsByAssignedtoo(LeadsDetail leads)
        {
            return Ok(leadsService.GetleadDetailsByAssignedtoo(leads));
        }


        [HttpPost]
        [Route("CreateCrmComments")]
        public IActionResult CreateCrmComments(CrmComments crmComments )
        {
            return Ok(leadsService.CreateCrmComments(crmComments));
        }

        [HttpPost]
        [Route("GetComments")]
        public IActionResult GetComments(CrmComments crmComments )
        {
            return Ok(leadsService.GetComments(crmComments));
        }

        [HttpPost]
        [Route("ReadLeadNotification")]
        public IActionResult ReadLeadNotification(LeadsDetail? leadsDetail  )
        {
            return Ok(leadsService.ReadLeadNotification(leadsDetail));
        }


    }
}
