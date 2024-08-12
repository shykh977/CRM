using BTG_CRM.Common;
using BTG_CRM.DbConnect;
using BTG_CRM.Model;
using BTG_CRM.Model.ViewModel;

namespace BTG_CRM.DataLayer
{
    public class LeadsService
    {

        private IGenericRepository<Leads> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public LeadsService(IGenericRepository<Leads> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse CreateLeads(Leads leads )
        {
            if (leads.LeadsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                leads.LeadsId = Guid.NewGuid();
            }
            var CF = _IgenericRepository.ExecuteQuery<Leads>(leads, "usp_Create_Update_Leads").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }
        
        public APIResponse GetLeadsFilter(LeadsFilter leads )
        {

            if(leads.LeadsId            == ""){leads.LeadsId         = null;}
            if(leads.CreatedBy          == ""){leads.CreatedBy       = null;}
            if(leads.CreatedOn          == ""){leads.CreatedOn       = null;}
            if(leads.AssignedToo        == ""){leads.AssignedToo     = null;}
            if(leads.CC                 == ""){leads.CC              = null;}
            if(leads.City               == ""){leads.City            = null;}
            if(leads.Area               == ""){leads.Area            = null;}
            if(leads.Status             == ""){leads.Status          = null;}
            if(leads.ActivityReminder   == ""){leads.ActivityReminder= null;}
            if(leads.Feedback           == ""){leads.Feedback        = null;}
            if(leads.LeadNo             == ""){ leads.LeadNo = null; }
            if (leads.IsWin == "")             { leads.IsWin = null; }

            List<LeadsView> LV = _IgenericRepository.ExecuteQuery<LeadsView>(leads, "usp_GetLeadsFilter").ToList();
            APIResponse.Response = LV;
            return APIResponse;
        }

        public APIResponse GetleadDetails(LeadsDetail leads )
        {

            object obj = new
            {
                LeadsId = leads.LeadsId
            };

            List<LeadsView> LV = _IgenericRepository.ExecuteQuery<LeadsView>(obj, "usp_GetleadDetails").ToList();
            APIResponse.Response = LV;
            return APIResponse;
        }
         public APIResponse GetleadDetailsByAssignedtoo(LeadsDetail leads )
        {

            object obj = new
            {
                AssignedToo = leads.AssignedToo
            };

            List<LeadsView> LV = _IgenericRepository.ExecuteQuery<LeadsView>(obj, "usp_GetleadDetails").ToList();
            APIResponse.Response = LV;
            return APIResponse;
        }

        public APIResponse CreateLeadDetail(LeadsDetail leads)
        {
            if (leads.LeadDetailId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                leads.LeadDetailId = Guid.NewGuid();
            }
            var CF = _IgenericRepository.ExecuteQuery<Leads>(leads, "usp_Create_Update_LeadsDetail").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }
        
        
        public APIResponse CreateCrmComments(CrmComments crmComments )
        {
            if (crmComments.CrmCommentsId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                crmComments.CrmCommentsId = Guid.NewGuid();
            }
            var CF = _IgenericRepository.ExecuteQuery<CrmComments>(crmComments, "usp_Create_Update_CrmComments").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }
        
        
        public APIResponse GetComments(CrmComments crmComments )
        {
            object obj = new
            {
                SourceId = crmComments.SourceId
            };
            var CF = _IgenericRepository.ExecuteQuery<CommentsView>(obj, "usp_GetComments").ToList();
            APIResponse.Response = CF;
            return APIResponse;
        } 
        
        
        public APIResponse ReadLeadNotification(LeadsDetail? leadsDetail )
        {
            object obj = new
            {
                LeadDetailId = leadsDetail.LeadDetailId
            };
            var CF = _IgenericRepository.ExecuteQuery<LeadsDetail>(obj, "ReadLeadNotification").ToList();
            APIResponse.Response = CF;
            return APIResponse;
        }
    }
}
