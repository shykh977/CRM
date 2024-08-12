namespace BTG_CRM.Model
{
    public class TicketDetail
    {
       public Guid      TicketsDetailId     {get;set;}
       public Guid      TicketsId           {get;set;}
       public Guid      AssignedToo         {get;set;}
       public Guid      AssignedFrom        {get;set;}
       public Guid UserId { get;set;}
       public string?   Status          {get;set;}
       public string?   Periority       {get;set;}
       public string?   Image           {get;set;}
       public string? Description { get;set;}
       public Guid CC { get;set;}
    }
}
