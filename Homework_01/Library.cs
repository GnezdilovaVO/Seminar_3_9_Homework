public static class Library
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static string GetOrder(int number)
    {
        if (number == 0) return String.Empty;
        else return number + " " + GetOrder(number-1);
    }
}