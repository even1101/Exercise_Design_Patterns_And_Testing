namespace ConsoleApp3.State.Order.s2;

public class InitStatus : IPaymentStatus
{
    private PaymentGate _paymentGate;

    public InitStatus(PaymentGate paymentGate)
    {
        _paymentGate = paymentGate;
    }

    public string Running(Product p)
    {
        _paymentGate.State = new ProcessStatus(_paymentGate);
        return "交易建立中...";    }

    public string SetStatus(PayStatus s)
    {
        string result = "";
        if (s == PayStatus.Init)
            result = "請勿重新建立訂單";
        else
            _paymentGate.CurrentStatus = s;

        return result;
    }
}