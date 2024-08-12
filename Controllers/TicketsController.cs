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
    public class TicketsController : ControllerBase
    {
        private IGenericRepository<Tickets> _IgenericRepository;

        TicketService ticketService  = null;

        public TicketsController(IGenericRepository<Tickets> igenericRepository)
        {
            ticketService = new TicketService(igenericRepository);
        }


        [HttpPost]
        [Route("CreateTickets")]
        public IActionResult CreateTickets(Tickets tickets )
        {
            return Ok(ticketService.CreateTickets(tickets));
        }
        
        [HttpPost]
        [Route("GetTickets")]
        public IActionResult GetTickets(TicketsFilter ticketsFilter  )
        {
            return Ok(ticketService.GetTickets(ticketsFilter));
        }
         
        [HttpPost]
        [Route("GetTicketsDetail")]
        public IActionResult GetTicketsDetail(TicketsFilter ticketsFilter  )
        {
            return Ok(ticketService.GetTicketsDetail(ticketsFilter));
        }
        
        [HttpPost]
        [Route("CreateTicketTags")]
        public IActionResult CreateTicketTags(TicketTag ticketTag  )
        {
            return Ok(ticketService.CreateTicketTags(ticketTag));
        }
        
        
        [HttpPost]
        [Route("CreateTicketsDetail")]
        public IActionResult CreateTicketsDetail(TicketDetail ticketDetail)
        {
            return Ok(ticketService.CreateTicketsDetail(ticketDetail));
        }
        
        [HttpPost]
        [Route("GetTicketTags")]
        public IActionResult GetTicketTags(Departments ticketTag  )
        {
            return Ok(ticketService.GetTicketTags(ticketTag));
        }

    }
}
