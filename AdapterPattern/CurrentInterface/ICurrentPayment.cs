namespace AdapterPattern.CurrentInterface
{
    public interface ICurrentPayment
    {
        string ProccessPayment(string name, decimal amount);
    }
}
