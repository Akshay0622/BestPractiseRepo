public class FriendlyPair
 {
   public static void Main (String[]args)
   {

     int num1 = 30, num2 = 140;

     int sum1 = GetDivisorsSum (num1);
     int sum2 = GetDivisorsSum (num2);

     if (sum1 / num1 == sum2 / num2)
       Console.WriteLine (num1 + " & " + num2 + " are friendly pairs");
     else
          Console.WriteLine (num1 + " & " + num2 + " are not friendly pairs");
   }

   static int GetDivisorsSum (int num)
   {

     int sum = 0;

     for (int i = 1; i < num; i++)
       {
 	    if (num % i == 0)
 	    sum = sum + i;
       }
     return sum;
   }
 }