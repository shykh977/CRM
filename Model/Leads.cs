namespace BTG_CRM.Model
{
    public class Leads
    {
          public Guid LeadsId                 {get;set;}
          public string?    Subject              {get;set;}
          public string?    Description          {get;set;}
          public string?    Image                {get;set;}
          public Guid       UserId              {get;set;}
          public Guid       AssignedToo             {get;set;}
          public Guid       CC                   {get;set;}
          public int        City                     {get;set;}
          public int        Area                     {get;set;}
          public string?    Status               {get;set;}
          public string?    Comment              {get;set;}
          public string?    ActivityReminder     {get;set;}
          public string?    ActivityNote         {get;set;}
          public string?    Feedback             {get;set;}
          public string?    FeedbackReason       {get;set;}
          public int        IsWin                { get; set; }



    }
}
