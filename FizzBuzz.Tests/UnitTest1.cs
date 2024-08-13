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
    public void convert_number_to_fizzbuzz_string(int input, string expected)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(expected));
    }

    // [TestCase(3, "Fizz")]
    [TestCase(6, "Fizz")]
    [TestCase(9, "Fizz")]
    public void convert_multiples_of_3_to_fizz(int input, string expected)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(expected));
    }

    // [TestCase(5, "Buzz")]
    [TestCase(10, "Buzz")]
    [TestCase(20, "Buzz")]
    public void convert_multiples_of_5_to_buzz(int number, string expected)
    {
        Assert.That(FizzBuzzClass.convert(number), Is.EqualTo(expected));
    }

    // [TestCase(15, "FizzBuzz")]
    // [TestCase(30, "FizzBuzz")]
    // [TestCase(45, "FizzBuzz")]
    public void convert_multiples_of_3_and_5_to_fizzbuzz(int input, string expected)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(expected));
    }

    [TestCase(3, "FizzFizz")]
    [TestCase(13, "Fizz")]
    [TestCase(23, "Fizz")]
    [TestCase(30, "FizzFizzBuzz")]

    public void convert_containing_3_to_additional_fizz(int input, string expected)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(expected));
    }

    [TestCase(5, "BuzzBuzz")]
    [TestCase(15, "FizzBuzzBuzz")]
    [TestCase(25, "BuzzBuzz")]
    [TestCase(35, "FizzBuzzBuzz")]
    [TestCase(45, "FizzBuzzBuzz")]
    public void convert_containing_5_to_additonal_buzz(int input, string expected)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(expected));
    }
    [TestCase(33, "FizzFizzFizz")]
    [TestCase(333, "FizzFizzFizzFizz")]
    [TestCase(353, "FizzFizzBuzz")]
    [TestCase(3937, "FizzFizz")]
    public void convert_containing_more_than_one_3_to_additionals_fizz(int input, string expected)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(expected));
    }

    [TestCase(55, "BuzzBuzzBuzz")]
    [TestCase(555, "FizzBuzzBuzzBuzzBuzz")]
    [TestCase(595, "BuzzBuzzBuzz")]
    [TestCase(58591, "BuzzBuzz")]
    [TestCase(58531, "FizzBuzzBuzz")]
    [TestCase(58533, "FizzFizzFizzBuzzBuzz")]
    public void convert_containing_more_than_one_5_to_additionals_buzz(int input, string expected)
    {
        Assert.That(FizzBuzzClass.convert(input), Is.EqualTo(expected));
    }

}
;