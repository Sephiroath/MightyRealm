using MightyRealm.Helpers.Enum.People;

namespace MightyRealm.Core.Stats
{
    public abstract class _Stats : IAttribute
    {
        protected Attributes AttributeType { get; set; }
        private long Amount { get; set; }    
        
        public long GetAmount()
        {
            return Amount;
        }

        public Attributes GetAttribute()
        {
            return AttributeType;
        }
    }    
}