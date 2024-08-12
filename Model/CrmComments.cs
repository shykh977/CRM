namespace BTG_CRM.Model
{
    public class CrmComments
    {
      public Guid  CrmCommentsId        {get;set;}
      public Guid    CommentFrom          {get;set;}
      public Guid    SourceId             {get;set;}
      public string?  Comment            {get;set;}
      public string? CommentType { get; set; }
        


    }
}
