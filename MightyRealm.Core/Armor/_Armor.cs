using System;
using System.Collections.Generic;
using MightyRealm.Helpers.Enum.People;

namespace MightyRealm.Core.Armor
{
    public abstract class _Armor : IArmor
    {
        public List<StatTypes> StatTypeses { get; set; }
    }
}