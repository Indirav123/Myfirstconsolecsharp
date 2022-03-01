using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirstconsolecsharp
{
    internal class looping
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter the number");
            num=int.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int num1;
            Console.WriteLine("Enter the values of num1");
            num1 = int.Parse(Console.ReadLine());
            int j = 0;
            while (j < num1)
            {
                Console.WriteLine(j);
                j++;
            }
            //do while
            int num2;
            Console.WriteLine("Enter the value of num2");
            num2=int.Parse(Console.ReadLine());
            int k = 10;
            do
            {
                Console.WriteLine(k);
                k++;
            }while(k< num2);            
            Console.ReadLine();
        }

    }
}
