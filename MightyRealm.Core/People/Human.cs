using System.Collections.Generic;
using System.Linq;
using MightyRealm.Core.Magic;
using MightyRealm.Core.Stats;
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

        #region Personal Info

        public string Name { get; set; }
        public string FamilyName { get; set; }

        #endregion

        #region Attributes

        public long MaxHealth { get; set; }
        public long CurrentHealth { get; set; }
        public long MaxDamage { get; set; }
        public long MaxDefense { get; set; }
        public List<Element> Elements { get; set; }
        public List<IAttribute> Attributeses { get; set; }

        public long CurrentIntelligence => GetCurrentAttribute(Attributes.Intelligence);
        public long CurrentStrength => GetCurrentAttribute(Attributes.Strength);
        public long CurrentDexterity => GetCurrentAttribute(Attributes.Dexterity);

        #endregion

        #region Rank

        public Warrior WarriorRank { get; set; }
        public Magus MagusRank { get; set; }
        public Saints SaintsRank { get; set; }
        public DemiGod DemigodRank { get; set; }
        public God GodRank { get; set; }
        public HighGod HighGodRank { get; set; }
        public Sovereign Sovereign { get; set; }

        #endregion

        #region PrivateMethods
        
        private long GetCurrentAttribute(Attributes attribute)
        {
            return Attributeses.Where(attributese => attributese.GetAttribute() == attribute).Aggregate<IAttribute, long>(0, (current, attributese) => current + attributese.GetAmount());
        }

        #endregion
        
    }
}