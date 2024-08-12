namespace BTG_CRM.Model
{
    public class CrmUsers
    {
       public Guid CrmUsersId       {get;set;}
       public Guid DepartmentId     {get;set;}
       public Guid UserId { get;set;}
       public Guid Insertedby { get;set;}
       public string? Username      {get;set;}
       public string? Email         {get;set;}
       public string? Desination { get; set; }
    }
}
