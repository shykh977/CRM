namespace BTG_CRM.Model
{
    public class UserLogin
    {
       public Guid      UserId             {get;set;}
       public int    UserType           {get;set;}
       public Guid      UserTypeId         {get;set;}
       public string?    UserName           {get;set;}
       public string?    Email              {get;set;}
       public string?    Password           {get;set;}
       public Guid BusinessId { get; set; }



    }
}
