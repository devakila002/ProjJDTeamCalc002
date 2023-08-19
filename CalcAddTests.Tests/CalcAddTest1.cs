namespace CalcAddTests.Tests;

public class CalcAddTest1
{
    [Fact]
    public void CheckIf5Plus7Equals12Test()
    {
        //Arrange
        Calculator myCalc = new Calculator();
        //Act
        int sumOf5And7 = myCalc.AddNumbers(5, 7);
        //Assert
        Assert.Equal(12, sumOf5And7);
    }
}