public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int GetAkkerman(int m, int n)
    {
        if (m == 0) return n+1;
        else if (m >0 && n == 0) return GetAkkerman(m-1, 1);
        else return GetAkkerman(m-1, GetAkkerman(m, n-1));
    }
}