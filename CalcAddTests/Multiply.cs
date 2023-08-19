using ProjCalc;
namespace CalcAddTests;

public class MultiplicationTest
{
    [Fact]
    public void check5multiplied2is10()
    {
        // Arrange
        Calculator MultipleCalc= new Calculator();
        // Act
        int multiply5by2 = MultipleCalc.multiplied5by2();
        //Assert
        Assert.Equal(10,multiply5by2);
    }
    }