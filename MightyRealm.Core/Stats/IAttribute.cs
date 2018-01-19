using MightyRealm.Helpers.Enum.People;

namespace MightyRealm.Core.Stats
{
    public interface IAttribute
    {
        long GetAmount();
        Attributes GetAttribute();
    }
}