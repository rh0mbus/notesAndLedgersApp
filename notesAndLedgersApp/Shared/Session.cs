namespace notesAndLedgersApp.Shared
{
    public class Session
    {
        public int Id { get; set; }
        public List<Note> SessionNotes { get; set; }
        public DateTime SessionDate { get; set; }
        public string SessionName { get; set; }
        public string SessionComments { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
