namespace _100Codes
{
  internal class Sum
  {
    static void Main(string[] args)
    {
      int n = 10;

      int sum = 0;

      for (int i = 1; i <= n; i++)
        sum += i;
      Console.WriteLine(sum);
    }
  }
}