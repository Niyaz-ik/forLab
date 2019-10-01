using Xunit;

public class TestCalc{
    Calculator test = new Calculator();
    int x3, y3;
    double tempRez;
    [Fact]
    public void Test1()
    {
        x3 = 5;
        y3 = 2;
        test.division(x3, y3);
        double expect = 2.5;
        tempRez = test.GetDouble();
        Assert.Equal(expect, tempRez);
    //Then
    }
    [Fact]
    public void Test2()
    {
        x3 = 5;
        y3 = 0;
        test.division(x3, y3);
        Assert.True(!(test.ErrorForTest()));
    }
    [Fact]
    public void Test3()
    {
        x3 = 5;
        y3 = 2;
        test.addition(x3, y3);
        double expect = 7;
        tempRez = test.GetInt();
        Assert.Equal(expect, tempRez);
    }
    [Fact]
    public void Test4()
    {
        x3 = 5;
        y3 = 2;
        test.subtraction(x3, y3);
        double expect = 3;
        tempRez = test.GetInt();
        Assert.Equal(expect, tempRez);
    }
    [Fact]
    public void Test5()
    {
        x3 = 5;
        y3 = 2;
        test.multiplication(x3, y3);
        double expect = 10;
        tempRez = test.GetInt();
        Assert.Equal(expect, tempRez);
    }
    [Fact]
    public void Test6()
    {
        x3 = 5;
        y3 = 2;
        test.exponentiation(x3, y3);
        double expect = 25;
        tempRez = test.GetDouble();
        Assert.Equal(expect, tempRez);
    }
    [Fact]
    public void Test7()
    {
        x3 = 100;
        y3 = 15;
        test.addInterest(x3, y3);
        double expect = 115;
        tempRez = test.GetDouble();
        Assert.Equal(expect, tempRez);
    }
    
}