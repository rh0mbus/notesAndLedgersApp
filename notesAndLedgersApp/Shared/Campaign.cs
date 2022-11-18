namespace notesAndLedgersApp.Shared
{
    public class Campaign
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Session> Session { get; set; } = new List<Session>();
        public Character? Character { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Description { get; set; }
    }
}
