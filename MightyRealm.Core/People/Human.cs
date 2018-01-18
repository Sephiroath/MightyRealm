using MightyRealm.Helpers.Enum.People;

namespace MightyRealm.Core.People
{
    public class Human : _People
    {
        public Human()
        {
            WarriorRank = Warrior.FirstRank;
            MagusRank = Magus.None;
            SaintsRank = Saints.None;
            DemigodRank = DemiGod.None;
            GodRank = God.None;
            HighGodRank = HighGod.None;
            Sovereign = Sovereign.None;
        }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public Warrior WarriorRank { get; set; }
        public Magus MagusRank { get; set; }
        public Saints SaintsRank { get; set; }
        public DemiGod DemigodRank { get; set; }
        public God GodRank { get; set; }
        public HighGod HighGodRank { get; set; }
        public Sovereign Sovereign { get; set; }
    }
}