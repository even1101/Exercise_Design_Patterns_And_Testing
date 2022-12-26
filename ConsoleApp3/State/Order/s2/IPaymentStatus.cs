namespace ConsoleApp3.State.Order.s2;

public interface IPaymentStatus
{
    // protected PaymentGate _gate;
    public string Running(Product p);
    public string SetStatus(PayStatus s);
}