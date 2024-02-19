namespace CheckoutKata.Interfaces
{
    public interface ICheckout
    {
        void Scan(string item);
        double Total { get; }
    }
}