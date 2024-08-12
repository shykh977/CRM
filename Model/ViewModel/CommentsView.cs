namespace BTG_CRM.Model.ViewModel
{
    public class CommentsView
    {
        public Guid CrmCommentsId { get; set; }
        public Guid CommentFrom { get; set; }
        public Guid SourceId        { get; set; }
        public string? Comment      { get; set; }
        public string? CommentType  { get; set; }
        public string? Username     { get; set; }
        public string? InsertedOn   { get; set; }

    }
}
