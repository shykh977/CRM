using BTG_CRM.DbConnect;
using BTG_CRM.Model;
using BTG_CRM.Common;
using BTG_CRM.Model.ViewModel;

namespace BTG_CRM.DataLayer
{
    public class TicketService
    {
        private IGenericRepository<Tickets> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public TicketService(IGenericRepository<Tickets> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

       
        public APIResponse CreateTicketTags(TicketTag ticketTag)
        {
            if (ticketTag.TicketTagsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                ticketTag.TicketTagsId = Guid.NewGuid();
            }
            var CF = _IgenericRepository.ExecuteQuery<TicketTag>(ticketTag, "usp_Create_Update_TicketTags").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }
        public APIResponse GetTicketTags(Departments ticketTag)
        {

            object obj = new
            {
                BusinessId = ticketTag.BusinessId
            };

            List<TicketTag> ticketTags = _IgenericRepository.ExecuteQuery<TicketTag>(obj, "usp_GetTicketTags").ToList();
            APIResponse.Response = ticketTags;
            return APIResponse;
        }


        public APIResponse CreateTickets(Tickets tickets)
        {



            Guid TicketsId = Guid.NewGuid();

            if (tickets.TicketsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                tickets.TicketsId = TicketsId;
            }

            TicketDetail ticketDetail = new TicketDetail
            {

                TicketsDetailId = Guid.NewGuid(),
                TicketsId = TicketsId,
                AssignedToo = tickets.AssignedToo,
                AssignedFrom = tickets.UserId,
                Status = tickets.Status,
                Periority = tickets.Periority,
                Image = tickets.Image,
                UserId = tickets.UserId
            };

            _IgenericRepository.ExecuteQuery<Tickets>(ticketDetail, "usp_Create_Update_TicketsDetail").FirstOrDefault();

            var CF = _IgenericRepository.ExecuteQuery<Tickets>(tickets, "usp_Create_Update_Tickets").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }


        public APIResponse GetTickets(TicketsFilter ticketsFilter )
        {

            if(ticketsFilter.TicketNo == "")
            {
                ticketsFilter.TicketNo = null;
            }
            if(ticketsFilter.Sources == "")
            {
                ticketsFilter.Sources = null;
            }
            if(ticketsFilter.Status == "")
            {
                ticketsFilter.Status = null;
            }
            if(ticketsFilter.TagId == "")
            {
                ticketsFilter.TagId = null;
            }
            if(ticketsFilter.TicketFromId == "")
            {
                ticketsFilter.TicketFromId = null;
            }
            if(ticketsFilter.TicketFrom == "")
            {
                ticketsFilter.TicketFrom = null;
            }
            if(ticketsFilter.Periority == "")
            {
                ticketsFilter.Periority = null;
            }
            if(ticketsFilter.Area == "")
            {
                ticketsFilter.Area = null;
            }
            if(ticketsFilter.City == "")
            {
                ticketsFilter.City = null;
            }
            if(ticketsFilter.CC == "")
            {
                ticketsFilter.CC = null;
            }
            if(ticketsFilter.AssignedDepartment == "")
            {
                ticketsFilter.AssignedDepartment = null;
            }
            if(ticketsFilter.CreatedOn == "")
            {
                ticketsFilter.CreatedOn = null;
            }
            if(ticketsFilter.CreatedBy == "")
            {
                ticketsFilter.CreatedBy = null;
            }
            if(ticketsFilter.Description == "")
            {
                ticketsFilter.Description = null;
            }
            if(ticketsFilter.Subject == "")
            {
                ticketsFilter.Subject = null;
            }
            if(ticketsFilter.TicketsId == "")
            {
                ticketsFilter.TicketsId = null;
            }
            if (ticketsFilter.AssignedFrom == "")
            {
                ticketsFilter.AssignedFrom = null;
            }
            if(ticketsFilter.AssignedToo == "")
            {
                ticketsFilter.AssignedToo = null;
            }

            List<TicketsView> ticketTags = _IgenericRepository.ExecuteQuery<TicketsView>(ticketsFilter, "usp_GetTicketsFilter").ToList();
            APIResponse.Response = ticketTags;
            return APIResponse;
        }
       
        public APIResponse GetTicketsDetail(TicketsFilter ticketsFilter )
        {

            if(ticketsFilter.TicketNo == "")
            {
                ticketsFilter.TicketNo = null;
            }
            if(ticketsFilter.Sources == "")
            {
                ticketsFilter.Sources = null;
            }
            if(ticketsFilter.Status == "")
            {
                ticketsFilter.Status = null;
            }
            if(ticketsFilter.TagId == "")
            {
                ticketsFilter.TagId = null;
            }
            if(ticketsFilter.TicketFromId == "")
            {
                ticketsFilter.TicketFromId = null;
            }
            if(ticketsFilter.TicketFrom == "")
            {
                ticketsFilter.TicketFrom = null;
            }
            if(ticketsFilter.Periority == "")
            {
                ticketsFilter.Periority = null;
            }
            if(ticketsFilter.Area == "")
            {
                ticketsFilter.Area = null;
            }
            if(ticketsFilter.City == "")
            {
                ticketsFilter.City = null;
            }
            if(ticketsFilter.CC == "")
            {
                ticketsFilter.CC = null;
            }
            if(ticketsFilter.AssignedDepartment == "")
            {
                ticketsFilter.AssignedDepartment = null;
            }
            if(ticketsFilter.CreatedOn == "")
            {
                ticketsFilter.CreatedOn = null;
            }
            if(ticketsFilter.CreatedBy == "")
            {
                ticketsFilter.CreatedBy = null;
            }
            if(ticketsFilter.Description == "")
            {
                ticketsFilter.Description = null;
            }
            if(ticketsFilter.Subject == "")
            {
                ticketsFilter.Subject = null;
            }
            if(ticketsFilter.TicketsId == "")
            {
                ticketsFilter.TicketsId = null;
            }
            if (ticketsFilter.AssignedFrom == "")
            {
                ticketsFilter.AssignedFrom = null;
            }
            if(ticketsFilter.AssignedToo == "")
            {
                ticketsFilter.AssignedToo = null;
            }

            List<TicketsView> ticketTags = _IgenericRepository.ExecuteQuery<TicketsView>(ticketsFilter, "usp_GetTicketsDetail").ToList();
            APIResponse.Response = ticketTags;
            return APIResponse;
        }


        public APIResponse CreateTicketsDetail(TicketDetail ticketDetail)
        {

            if (ticketDetail.TicketsDetailId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                ticketDetail.TicketsDetailId = Guid.NewGuid();
            }

            var CF = _IgenericRepository.ExecuteQuery<TicketDetail>(ticketDetail, "usp_Create_Update_TicketsDetail").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }



    }
}
