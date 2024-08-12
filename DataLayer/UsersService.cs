using BTG_CRM.DbConnect;
using BTG_CRM.Model;
using BTG_CRM.Common;


namespace BTG_CRM.DataLayer
{
    public class UsersService
    {
        private IGenericRepository<Departments> _IgenericRepository;

        APIResponse APIResponse = new APIResponse();

        public UsersService(IGenericRepository<Departments> igenericRepository)
        {
            _IgenericRepository = igenericRepository;
        }


        public APIResponse CreateDepartments(Departments departments )
        {

            if(departments.DepartmentId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                departments.DepartmentId = Guid.NewGuid();
            }

            var CF = _IgenericRepository.ExecuteQuery<Departments>(departments, "usp_Create_Update_Departments").FirstOrDefault();
            APIResponse.Response = CF;
            return APIResponse;
        }
        
        public APIResponse GetDepartments(Departments departments )
        {
            object obj = new
            {
                BusinessId = departments.BusinessId
            };
            List<Departments> depart = _IgenericRepository.ExecuteQuery<Departments>(obj, "usp_GetDepartments").ToList();
            APIResponse.Response = depart;
            return APIResponse;
        }
        
        public APIResponse LoginUser(UserLogin userLogin  )
        {
            object obj = new
            {
                Username = userLogin.Email,
                Password = userLogin.Password

            };
            var LoginData = _IgenericRepository.ExecuteQuery<UserLogin>(obj, "usp_LoginUser").FirstOrDefault();



            if(LoginData != null)
            {
                APIResponse.StatusMessage = "SUCCESS";
                APIResponse.Response = LoginData;
            }
            else
            {
                APIResponse.StatusMessage = "Login Failed Check Username Or Password";
            }
            
            return APIResponse;
        }
        
        
        public APIResponse CreateCrmUsers(CrmUsers crmUsers )
        {


            Guid Userid = Guid.NewGuid();
            Guid CrmUserId = Guid.NewGuid();


            if (crmUsers.CrmUsersId.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                crmUsers.CrmUsersId = Guid.NewGuid();
            
            }
            crmUsers.CrmUsersId = CrmUserId;

            UserLogin Ul = new UserLogin
            {
                UserId   = Userid,
                UserType = 2,
                UserTypeId = CrmUserId,
                UserName = crmUsers.Username ,
                Email    = crmUsers.Email,
                Password = "crm2023"
            };


            _IgenericRepository.ExecuteQuery<UserLogin>(Ul, "usp_Create_Update_UserLogin").FirstOrDefault();
            var Crm = _IgenericRepository.ExecuteQuery<Departments>(crmUsers, "usp_Create_Update_CrmUsers").FirstOrDefault();
            APIResponse.Response = Crm;
            return APIResponse;
        }
        
        
        public APIResponse GetCrmUser(CrmUsers crmUsers )
        {
            object obj = new
            {
                DepartmentId = crmUsers.DepartmentId
            };
            List<CrmUsers> Crm = _IgenericRepository.ExecuteQuery<CrmUsers>(obj, "usp_GetCrmUser").ToList();
            APIResponse.Response = Crm;
            return APIResponse;
        }
        
        public APIResponse GetCrmUserById(CrmUsers crmUsers )
        {
            object obj = new
            {
                CrmUsersId = crmUsers.CrmUsersId
            };
            List<CrmUsers> Crm = _IgenericRepository.ExecuteQuery<CrmUsers>(obj, "usp_GetCrmUser").ToList();
            APIResponse.Response = Crm;
            return APIResponse;
        }
        
        
        public APIResponse GetCrmUserAll(Departments crmUsers )
        {
            object obj = new
            {
                BusinessId = crmUsers.BusinessId
            };
            List<CrmUsers> Crm = _IgenericRepository.ExecuteQuery<CrmUsers>(obj, "usp_GetCrmUser").ToList();
            APIResponse.Response = Crm;
            return APIResponse;
        }
    }
}
