using MightyRealm.Helpers.Enum.People;

namespace MightyRealm.Core.Stats
{
    public interface IStat
    {
        long GetAmount();
        StatTypes GetAttribute();
    }
}