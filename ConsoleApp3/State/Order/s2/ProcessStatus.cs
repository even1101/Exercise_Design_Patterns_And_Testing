namespace ConsoleApp3.State.Order.s2;

public class ProcessStatus : IPaymentStatus
{
    private PaymentGate _paymentGate;
    public ProcessStatus(PaymentGate paymentGate)
    {
        _paymentGate = paymentGate;
    }

    public string Running(Product p)
    {
        string result = "交易中請稍後";

        if (p.Price > 300)
        {
            result = "物件超過300元 交易取消中";
            _paymentGate.State = new CancelStatus(_paymentGate);
        }
        else
        {
            _paymentGate.State = new SuccessStatus(_paymentGate);
        }
        return result;
    }

    public string SetStatus(PayStatus s)
    {
        string result = string.Empty;
        if (s == PayStatus.Init) result = "請勿重新建立訂單";
        return result;
    }
}