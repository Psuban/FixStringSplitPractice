using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringSplitFIXPractive
{
    public class BasicExercises
    {
        public void RunAllExercises()
        {
            //Exercise1
                Console.WriteLine("Hello: Alexandra Abramov");
            
            //Exercise2
                Console.WriteLine(5 + 6);
            

            //Exercise3
                Console.WriteLine(10/5);
            

           //Exercise4
                Console.WriteLine(-1 +4*6);
                Console.WriteLine((35+5)%7);
                Console.WriteLine(14 + -4 * 6 / 11);
                Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            
           //Exercise5
            int firstNumber = 5;
            int secondNumber = 6;

            var tempNumber = secondNumber;
            secondNumber = firstNumber;
            firstNumber = tempNumber;
            Console.WriteLine("After swap");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);

            //Exercise6
            Console.WriteLine("Enter your first intger");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second integer");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your third integer");
            var num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + " x "  + num2 + " x " + num3 + " = " + (num1*num2*num3));

            //Exercise7
            Console.WriteLine("Enter your first integer");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second integer");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number1 + " + " +  number2 + " = " + (number1+number2));
            Console.WriteLine(number1 + " - " + number2 + " = " + (number1-number2));
            Console.WriteLine(number1 + " * " + number2 + " = " + (number1*number2));
            Console.WriteLine(number1 + " / " + number2 + " = " + number1/number2);
            Console.WriteLine(number1 + " % " + number2 + " = " + (number1%number2));

            //Exercise8


        }
    }
}
