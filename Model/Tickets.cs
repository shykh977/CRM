namespace BTG_CRM.Model
{
    public class Tickets
    {

        public Guid TicketsId { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public Guid UserId { get; set; }
        public Guid AssignedDepartment { get; set; }
        public Guid AssignedToo { get; set; }
        public Guid CC { get; set; }
        public int City { get; set; }
        public int Area { get; set; }
        public string? Periority { get; set; }
        public string? TicketFrom { get; set; }
        public Guid TicketFromId { get; set; }
        public Guid TagId { get; set; }
        public string? Status { get; set; }
        public string? Sources { get; set; }
                                      













    }
}
