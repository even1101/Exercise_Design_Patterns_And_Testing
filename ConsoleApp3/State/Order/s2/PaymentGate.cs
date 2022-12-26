namespace ConsoleApp3.State.Order.s2;

public class PaymentGate 
{
    private readonly Product _product;
    public IPaymentStatus State;
    
    public PaymentGate(Product p)
    {
        _product = p;
        if (this.State == null) State = new InitStatus(this);
    }
    
    internal PayStatus CurrentStatus { get; set; }
    
    public string RunProcess()
    {
        return State.Running(_product);
    }
    
    public string SetStatus(PayStatus s)
    {
        return State.SetStatus(s);
    }
}