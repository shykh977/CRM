namespace BTG_CRM.Model.ViewModel
{
    public class TicketsView
    {
     public string?   DepartmentName                {get;set;}
     public string? DetailDescription { get;set;}
     public string? NewStatus { get;set;}
     public string?   Assginee                      {get;set;}
     public string?   AssignFrom                    {get;set;}
     public string? NewPeriority { get;set;}
     public string?   CreaterName                   { get;set;}
     public string?   TicketTags                    {get;set;}
     public Guid       TicketsId                     {get;set;}
     public string?   Subject                       {get;set;}
     public string?   Description                   {get;set;}
     public string?   Image                         {get;set;}
     public Guid CreatedBy                     {get;set;}
     public string?   CreatedOn                     {get;set;}
     public Guid AssignedDepartment            {get;set;}
     public string? CarbonCopy { get;set;}
     public string?   City                          {get;set;}
     public string?   Area                          {get;set;}
     public string?   Periority                     {get;set;}
     public string?   TicketFrom                    {get;set;}
     public Guid   TicketFromId                  {get;set;}
     public Guid TagId                         {get;set;}
     public string?   Status                        {get;set;}
     public string? CurrentStatus { get;set;}
     public string?   Sources                       {get;set;}
     public string? TicketNo { get; set; }
    }
}
