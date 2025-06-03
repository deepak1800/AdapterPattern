namespace AdapterPattern.Legacyproduct
{
    public class LegacyPayment
    {
        public string MakePayment(string name, double amount)
        {
            return $"Payment of {amount} processed for {name}";
        }
    }
}
