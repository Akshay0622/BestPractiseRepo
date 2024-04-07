using System.Security.Cryptography.X509Certificates;

namespace _100Codes
{
    internal class PrimeNumber
    {
        public static void Main (string[]args){
           
          {
              int n = 23;
             checkPrime (n);
          }
        }      
       private static void checkPrime (int n)
 
  {
         int count = 0;

   
    if (n < 2)
      {
	Console.WriteLine("The given is number " + n + " is not prime");
	   return;
      }
  
    for (int i = 1; i <= n; i++)
      {
	if (n % i == 0)
	  count += 1;
      }

  
    if (count > 2)
      Console.WriteLine ("The given is number " + n + " is not prime");

    else
      Console.WriteLine ("The given is number " + n + " is prime");
  }
}
}