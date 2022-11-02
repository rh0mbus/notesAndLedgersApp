using notesAndLedgersApp.Shared.Enums;
using Microsoft.EntityFrameworkCore.Design;

namespace notesAndLedgersApp.Shared
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public CharacterClass CurrentClass { get; set; }
        //public List<CharacterClass> subClasses { get; set; } = new List<CharacterClass>();
        public CoinPurse CoinPurse { get; set; } = new CoinPurse();
    }
}