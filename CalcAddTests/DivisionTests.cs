using ProjCalc;
namespace CalcAddTests;

public class DivisionTest
{
    [Fact]
    public void check10minus5is0()
    {
        // Arrange
        Calculator DivisionCalc= new Calculator();
        // Act
        int divideOf2Nos = DivisionCalc.divide10by5();
        //Assert
        Assert.Equal(0,divideOf2Nos);
    }
}