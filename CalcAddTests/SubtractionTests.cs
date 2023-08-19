

namespace CalcAddTests;

public class SubractionTest
{
    [Fact]
    public void check4minus2is2()
    {
        // Arrange
        Calculator SubCalc= new Calculator();
        // Act
        int differenceOf2Nos = SubCalc.differenceOf4and2();
        //Assert
        Assert.Equal(2,differenceOf2Nos);
    }
}
