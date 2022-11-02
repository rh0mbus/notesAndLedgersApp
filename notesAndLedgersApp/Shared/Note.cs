using Newtonsoft.Json;
using System.Text.Json;

namespace notesAndLedgersApp.Shared
{
    public class Note
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
    }
}
