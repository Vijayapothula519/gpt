using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpt
{
    class Program
    {
       

class AdditionProgram
    {
        // Method to add two numbers
        static int AddNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
            static void fun(int x, int y)
            {
                x = 7;
                y = 5;
                Console.WriteLine("inside method is:" + x + "and" + y);

            }
            static void func(ref int a, ref int b)
            {
                a = 7;
                b = 5;
                Console.WriteLine("inside function is:" + a + "and" + b);

            }
            static void funct(out int c, out int d)
            {
                c = 7;
                d = 5;
                Console.WriteLine("inside function is out:" + c + "and" + d);

            }
            static void ModifyValue(ref int x)
            {
                x = 10;  // Changes made to x inside the method will reflect on the original variable.
            }

            static void Main()
        {
            // Input numbers
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Call the AddNumbers method
            int result = AddNumbers(num1, num2);

            // Display the result
            Console.WriteLine("result is"+result);


                int x = 5;
                int y = 7;
                fun(x, y);
                Console.WriteLine("main method is:" + x + "and" + y);

                int a = 5;
                int b = 7;
                Console.WriteLine("before fun:" + x + "and" + y);
                func(ref a, ref b);
                Console.WriteLine("after function:" + x + "and" + y);

                int c;
                int d;
                funct(out c, out d);
                Console.WriteLine("out keyword is:"+c + "and" + d);

                int num = 5;
                Console.WriteLine("Before method call: " + num);

                ModifyValue(ref num);

                Console.WriteLine("After method call: " + num);

                //break
                for (int i = 0; i <= 5; i++)
                {
                    if (i == 4)
                    {
                        //break;
                        continue;
                    }
                    Console.WriteLine("The number is " + i);
                }
                    


                    Console.ReadLine();
        }
            
    }

    }
}