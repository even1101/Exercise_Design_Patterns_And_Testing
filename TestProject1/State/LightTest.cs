using ConsoleApp3;
using ConsoleApp3.Light;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.State;

public class LightTest
{
    [Fact]
    public void Light_Switch_Is_On_Test()
    {
        var light = new Light(new LightOff());
        var result = light.Switch();
        Assert.Equal("On", result);
    }
    [Fact]
    public void Light_Switch_Is_LightAll_Test()
    {
        var light = new Light(new LightOn());
        var result = light.Switch();
        Assert.Equal("LightAll", result);
    }

    [Fact]
    public void Light_Switch_Is_LightThree_Test()
    {
        var light = new Light(new LightAll());
        var result = light.Switch();
        Assert.Equal("LightThree", result);
    }

    [Fact]
    public void Light_Switch_Is_LightTwo_Test()
    {
        var light = new Light(new LightThree());
        var result = light.Switch();
        Assert.Equal("LightTwo", result);
    }

    [Fact]
    public void Light_Switch_Is_LightOne_Test()
    {
        var light = new Light(new LightTwo());
        var result = light.Switch();
        Assert.Equal("LightOne", result);
    }

    [Fact]
    public void Light_Switch_Is_LightOff_Test()
    {
        var light = new Light(new LightOne());
        var result = light.Switch();
        Assert.Equal("Off", result);
    }
}


