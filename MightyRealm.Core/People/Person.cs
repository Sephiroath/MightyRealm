using MightyRealm.Helpers.Enum.People;

namespace MightyRealm.Core.People
{
    public class Human : _People
    {
        public Warriors WarriorRank { get; set; }
        public Magus MagusRank { get; set; }
    }
}