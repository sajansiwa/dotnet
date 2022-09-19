using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace week2


{
    internal class addition
    {
        public void Add()
        {
            Console.WriteLine("insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var addition = number1 + number2;
            Console.WriteLine($"{addition}");  
        }

        public void sub()
        {
            Console.WriteLine("insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var substraction = number1 + number2;   
            Console.WriteLine($"{substraction}");
        }

        public void div()
        {
            Console.WriteLine("insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int division = number1 / number2;
            Console.WriteLine($"{division}");
        }

        public void mul()
        {
            Console.WriteLine("insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int multiplication = number1 * number2;
            Console.WriteLine($"{multiplication}"); 
        }

      
    }
}
