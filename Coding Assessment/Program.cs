using System;
using System.Diagnostics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryCalc();
            GCF();

        }

        // Question 6

        static void BinaryCalc(int input = 0)
        {
            Console.WriteLine("Input your number");
            input = Convert.ToInt16(Console.ReadLine());
            string b = " " ;

            while(input > 0)
            {
                if (input % 2 == 0)
                {
                    input = input / 2;
                    b = "0" + b ;
                }
                else
                {
                    input = input / 2;
                    b = "1" + b;
                }

            }
            Console.WriteLine(b);

            


        }
         //Question 3
        static void GCF(int num1 = 0, int num2 = 0)
        {
            Console.WriteLine("Enter a whole number");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter another whole number");
            num2 = Convert.ToInt16(Console.ReadLine());
            int temp1 = num1;
            int temp2 = num2;

            while(temp1 != temp2)
            {
                if (temp1 > temp2)
                {
                    temp1 = temp1 - temp2;
                }
                else
                {
                    temp2 = temp2 - temp1;
                }
                
            }

            int result = temp1;
            Console.WriteLine(result + " is the GCF of " + num1 + " and " + num2);
                
            
        }

        // So that when it is printed at the end the values that were inputted initially will not be changed

    }
}