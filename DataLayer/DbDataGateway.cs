using BTG_CRM.DbConnect;
using BTG_CRM.Model;
using BTG_CRM.Common;

namespace BTG_CRM.DataLayer
{
    public class DbDataGateway
    {
        private IGenericRepository<Quries> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();


        public DbDataGateway(IGenericRepository<Quries> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }

        public APIResponse ExecuteQuery(Quries quries )
        {
            var CF = _IgenericRepository.ExecuteQuery<Quries>(quries, "Usp_ExecuteQuery").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }

    }
}
