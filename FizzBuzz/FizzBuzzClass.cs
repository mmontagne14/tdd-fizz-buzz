public static class FizzBuzzClass
{
    public static string convert(int number)
    {
        string numberString = Convert.ToString(number);
        string result = "";

        if (numberString.Contains('3'))
        {
            foreach (char c in numberString)
            {
                if (c == '3') result += "Fizz";
            }
        }


        if (number % 3 == 0) result += "Fizz";
        if (numberString.Contains('5'))
        {
            foreach (char c in numberString)
            {
                if (c == '5') result += "Buzz";
            }
        }
        if (number % 5 == 0) result += "Buzz";

        return !string.IsNullOrEmpty(result) ? result : numberString;
    }
}