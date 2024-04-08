namespace _100Codes
{
  internal class PerfectNumber
  {
    static void Main(string[] args)
    {
      int n = 10;

      int sum = 0;

      for (int i = 1; i <= n; i++)
      { if(n%2==0)
        sum += sum+i;
        
    }
    if(sum==n){
        Console.WriteLine("this is prime number");
    }
    else{
        Console.WriteLine("this is not prime number");
    }
  }
}
}