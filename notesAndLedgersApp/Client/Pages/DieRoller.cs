using Microsoft.AspNetCore.Components;
using notesAndLedgersApp.Shared.Enums;

namespace notesAndLedgersApp.Client.Pages
{
    public partial class DieRoller : ComponentBase
    {
        protected RollType RollType = RollType.Standard;
        protected int CurrentRoll = 0;
        protected int OtherRoll = 0;

        Random rand = new Random();

        private void RollDie()
        {
            RollType = RollType.Standard;
            CurrentRoll = rand.Next(20) + 1;
        }

        private void RollAdvantage()
        {
            RollType = RollType.Advantage;
            var roll1 = rand.Next(20) + 1;
            var roll2 = rand.Next(20) + 1;

            CurrentRoll = roll1 > roll2 ? roll1 : roll2; ;
            OtherRoll = roll1 > roll2 ? roll2 : roll1;
        }

        private void RollDisadvantage()
        {
            RollType = RollType.Disadvantage;
            var roll1 = rand.Next(20) + 1;
            var roll2 = rand.Next(20) + 1;
            CurrentRoll = roll1 < roll2 ? roll1 : roll2;
            OtherRoll = roll1 < roll2 ? roll2 : roll1;
        }
    }
}
