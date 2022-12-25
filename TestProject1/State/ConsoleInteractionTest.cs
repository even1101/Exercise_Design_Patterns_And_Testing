using ConsoleApp3.Shape;

namespace TestProject1.State;

public class ConsoleInteractionTest
{
    [Fact]
    public void Initial_And_Print()
    {
        Module module = new Module();
        string printed = module.Print();
        Assert.Equal("Shape: (C)ircle or (R)ectangle?", printed);
    }

    [Fact]
    public void Initial_And_R()
    {

        Module module = new Module();

        module.Input("R");

        string printed = module.Print();

        Assert.Equal("Rectangle side A length?", printed);


    }

    [Fact]
    void Initial_And_A()
    {

        Module module = new Module();

        module.Input("A");

        string printed = module.Print();

        Assert.Equal("Shape: (C)ircle or (R)ectangle?", printed);


    }

    [Fact]

    public void Initial_And_R_5()
    {

        Module module = new Module();

        module.Input("R");

        module.Input("5");

        string printed = module.Print();

        Assert.Equal("Rectangle side B length?", printed);


    }

    [Fact]
    public void Initial_And_R_6()
    {

        Module module = new Module();

        module.Input("R");

        module.Input("6");

        string printed = module.Print();

        Assert.Equal("Rectangle side B length?", printed);


    }

    [Fact]
    public void Initial_And_R_5_10()
    {

        Module module = new Module();

        module.Input("R");

        module.Input("5");
        module.Input("10");

        string printed = module.Print();

        Assert.Equal("Area=50, Circumference=30", printed);


    }

    [Fact]
    public void Initial_And_R_7_10()
    {

        Module module = new Module();

        module.Input("R");

        module.Input("7");
        module.Input("10");

        string printed = module.Print();

        Assert.Equal("Area=70, Circumference=34", printed);


    }

    [Fact]
    public void Initial_and_R_Z()
    {

        Module module = new Module();

        module.Input("R");

        module.Input("Z");

        string printed = module.Print();

        Assert.Equal("Rectangle side A length?", printed);


    }

    [Fact]
    public void Initial_And_C()
    {

        Module module = new Module();

        module.Input("C");

        string printed = module.Print();

        Assert.Equal("Circle radius?", printed);

    }

    [Fact]
    public void Initial_And_C_10()
    {

        Module module = new Module();

        module.Input("C");
        module.Input("10");

        string printed = module.Print();


        Assert.Equal("Area=300, Circumference=60", printed);

    }

    [Fact]
    public void Initial_And_C_100()
    {

        Module module = new Module();

        module.Input("C");
        module.Input("100");

        string printed = module.Print();


        Assert.Equal("Area=30000, Circumference=600", printed);

    }
}