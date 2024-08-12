namespace BTG_CRM.Model.ViewModel
{
    public class LeadsView
    {

        public Guid LeadsId { get; set; }
        public Guid LeadDetailId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Guid CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public Guid AssignedToo { get; set; }
        public Guid CC { get; set; }
        public int City { get; set; }
        public int Area { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string ActivityReminder { get; set; }
        public string ActivityNote { get; set; }
        public string Feedback { get; set; }
        public string FeedbackReason { get; set; }
        public string LeadNo { get; set; }
        public int IsWin { get; set; }
        public int IsNotify { get; set; }
        public string GeneratedBy { get; set; }
        public string CCUser { get; set; }
        public string Assignee { get; set; }
        public string AssignFrom { get; set; }



    }
}
