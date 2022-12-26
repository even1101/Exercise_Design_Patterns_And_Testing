namespace ConsoleApp3.State.Order.s2;

public class SuccessStatus : IPaymentStatus
{
    private PaymentGate _paymentGate;
    public SuccessStatus(PaymentGate paymentGate)
    {
        _paymentGate = paymentGate;
    }

    public string Running(Product p)
    {
        return "交易完成";
    }

    public string SetStatus(PayStatus s)
    {
        string result = string.Empty;
        if (s == PayStatus.Init) result = "訂單成功請勿修改";
        return result;
    }
}