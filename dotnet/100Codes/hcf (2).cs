using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Codes
{

    public class HCF{

        public static void Main(string[]args){

        int num1=36;
        int num2=60;
        int hcf=0;

        for(int i=1;num1>=i||num2>=i; i++){

           if(num1%i==0 && num2%i==0){
            hcf=i;
           }
          
        }
        Console.WriteLine("The HCF: "+ hcf);

    }
}
}


