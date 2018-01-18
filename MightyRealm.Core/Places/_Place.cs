using System.Collections.Generic;
using System.Numerics;
using MightyRealm.Core.People;
using MightyRealm.Helpers.Enum.People;

namespace MightyRealm.Core.Places
{
    public abstract class _Place
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Xlocation { get; set; }
        public long Ylocation { get; set; }
        public long Population { get; set; }
        public long Length { get; set; }
        public BigInteger CommonerPeopleAmount { get; set; }
        public Commoners Commoners { get; set; }
        public List<Human> Humans { get; set; }
    }
}