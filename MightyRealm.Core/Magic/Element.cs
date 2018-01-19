using MightyRealm.Helpers.Enum.Elements;

namespace MightyRealm.Core.Magic
{
    public class Element : _Magic
    {
        public Elements ElementType { get; set; }
        public int ElementAfinity { get; set; }
    }
}