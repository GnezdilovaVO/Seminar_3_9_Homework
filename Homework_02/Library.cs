public static class Library
{
    public static int GetNumber(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static int GetSum(int start, int finish)
    {
        if ( start > finish) return 0;
        else return start + GetSum(start+1, finish); 
    }
}