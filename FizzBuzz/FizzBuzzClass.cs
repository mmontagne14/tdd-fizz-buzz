public static class FizzBuzzClass
{
    public static string convert(int number)
    {
        bool isMultipleOf3 = MultipleChecker(number, 3);
        bool isMultipleOf5 = MultipleChecker(number, 5);
        if (isMultipleOf3 && isMultipleOf5)
            return "FizzBuzz";
        if (isMultipleOf3)
            return "Fizz";
        if (isMultipleOf5)
            return "Buzz";
        return Convert.ToString(number);
    }

    private static bool MultipleChecker(int number, int divider)
    {
        return number % divider == 0;
    }
}