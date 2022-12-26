using ConsoleApp3;
using ConsoleApp3.State.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.State.Order.s2;

namespace TestProject1.State;

public class OrderTest
{
    [Theory]
    [InlineData(PayStatus.Init, "請勿重新建立訂單")]
    [InlineData(PayStatus.Success, "修改成功Success")]
    [InlineData(PayStatus.Cancel, "修改成功Cancel")]
    [InlineData(PayStatus.Processing, "修改成功Processing")]
    public void Order_SetStatus_Is_Init_XUnitTest(PayStatus status, string target)
    {
        var product = new Product();
        var context = new PaymentContext(product);
        string result = context.SetStatus(status);
        Assert.Equal(target, result);
    }

    [Fact]
    public void Order_S1_Normal_Item_Test()
    {
        Product p = new Product() { Name = "蘋果", Price = 30 };
        PaymentGate context = new PaymentGate(p);

        Assert.Equal("交易建立中...", context.RunProcess());
        Assert.Equal("交易中請稍後", context.RunProcess());
        Assert.Equal("交易完成", context.RunProcess());
    }
    [Fact]
    public void Normal_OverPriceItem_Test()
    {
        Product p = new Product() { Name = "蘋果", Price = 5555 };
        PaymentGate context = new PaymentGate(p);

        Assert.Equal("交易建立中...", context.RunProcess());
        Assert.Equal("物件超過300元 交易取消中", context.RunProcess());
        Assert.Equal("交易取消完成", context.RunProcess());
    }
    [Fact]
    public void SetProcess_Cancel_AlterDontResetAgain_Test()
    {
        Product p = new Product() { Name = "蘋果", Price = 3000 };
        PaymentGate context = new PaymentGate(p);

        Assert.Equal("請勿重新建立訂單", context.SetStatus(PayStatus.Init));
        Assert.Equal("交易建立中...", context.RunProcess());
        Assert.Equal("請勿重新建立訂單", context.SetStatus(PayStatus.Init));
        Assert.Equal("物件超過300元 交易取消中", context.RunProcess());
        Assert.Equal("交易取消完成", context.RunProcess());
        Assert.Equal("訂單取消請勿修改", context.SetStatus(PayStatus.Init));
    }
    [Fact]
    public void SetProcess_Success_AlterDontResetAgain_Test()
    {
        Product p = new Product() { Name = "蘋果", Price = 30 };
        PaymentGate context = new PaymentGate(p);

        Assert.Equal("請勿重新建立訂單", context.SetStatus(PayStatus.Init));
        Assert.Equal("交易建立中...", context.RunProcess());
        Assert.Equal("請勿重新建立訂單", context.SetStatus(PayStatus.Init));
        Assert.Equal("交易中請稍後", context.RunProcess());
        Assert.Equal("交易完成", context.RunProcess());
        Assert.Equal("訂單成功請勿修改", context.SetStatus(PayStatus.Init));
    }




}
