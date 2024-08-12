using BTG_CRM.Common;
using BTG_CRM.DbConnect;

namespace BTG_CRM.DbConnecter
{
    public class ConnectionFactory :IConnection
    {
        public string ConnectionString
        {
            get
            {
                return APIConfig.Configuration.GetSection("ConnectionStrings")["DefaultConnection"];
            }
        }
    }
}
