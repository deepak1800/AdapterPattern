using AdapterPattern.CurrentInterface;
using AdapterPattern.Legacyproduct;

namespace AdapterPattern.Adapter
{
    public class AdapterClass: ICurrentPayment
    {
        private readonly LegacyPayment _legacyPayment;

        public AdapterClass()
        {
            _legacyPayment = new LegacyPayment();
        }

        public string ProccessPayment(string name, decimal amount)
        {
            return _legacyPayment.MakePayment(name, (double)amount);
        }
    }
}
