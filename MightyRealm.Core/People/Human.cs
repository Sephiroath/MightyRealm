using System.Collections.Generic;
using System.Linq;
using MightyRealm.Core.Magic;
using MightyRealm.Core.Stats;
using MightyRealm.Core.Weapon;
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
        public List<IStat> Attributeses { get; set; }

        public long CurrentIntelligence => GetCurrentAttribute(StatTypes.Intelligence);
        public long CurrentStrength => GetCurrentAttribute(StatTypes.Strength);
        public long CurrentDexterity => GetCurrentAttribute(StatTypes.Dexterity);

        #endregion

        #region Inventory

        public List<IWeapon> Weapons { get; set; }

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
        
        private long GetCurrentAttribute(StatTypes statType)
        {
            return Attributeses.Where(attributese => attributese.GetAttribute() == statType).Aggregate<IStat, long>(0, (current, attributese) => current + attributese.GetAmount());
        }

        #endregion
        
    }
}