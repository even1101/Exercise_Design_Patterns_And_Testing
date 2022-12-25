using ConsoleApp3;
using ConsoleApp3.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1;

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




}
