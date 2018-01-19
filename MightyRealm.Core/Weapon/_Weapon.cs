using MightyRealm.Core.Magic;
using MightyRealm.Helpers.Enum.Weapon;

namespace MightyRealm.Core.Weapon
{
    public class _Weapon : IWeapon
    {
        public Rarity Rarity { get; set; }
        public Element Element { get; set; }
        public bool IsMelee { get; set; }
    }
}