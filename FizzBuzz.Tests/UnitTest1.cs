namespace FizzBuzz.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, "1")]
    [TestCase(2, "2")]
    [TestCase(4, "4")]
    public void convert_positive_number_to_string(int input, string output)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(output));
    }

    [TestCase(3, "Fizz")]
    [TestCase(6, "Fizz")]
    [TestCase(9, "Fizz")]
    public void convert_multiples_of_3_to_Fizz(int input, string output)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(output));
    }

    [TestCase(5, "Buzz")]
    [TestCase(10, "Buzz")]
    [TestCase(20, "Buzz")]
    public void convert_multiples_of_5_to_Buzz(int input, string output)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(output));
    }


    [TestCase(15, "FizzBuzz")]
    [TestCase(30, "FizzBuzz")]
    [TestCase(45, "FizzBuzz")]
    public void convert_multiples_of_3_and_5_to_Buzz(int input, string output)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(output));
    }


}
;