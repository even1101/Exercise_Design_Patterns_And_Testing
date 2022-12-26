namespace ConsoleApp3.State.Order.s2;

public class CancelStatus : IPaymentStatus
{
    private PaymentGate _paymentGate;
    public CancelStatus(PaymentGate paymentGate)
    {
        _paymentGate = paymentGate;
    }

    public string Running(Product p)
    {
        return "交易取消完成";
    }

    public string SetStatus(PayStatus s)
    {
        string result = string.Empty;
        if (s == PayStatus.Init)
            result = "訂單取消請勿修改";
        return result;    }
}