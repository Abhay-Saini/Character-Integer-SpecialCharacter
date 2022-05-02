using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Integer_SpecialCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Please");

            Char Value = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("The value is {0} ", Value);

            if(Value >= 65 && Value <= 90 || Value >= 97 && Value <= 122)
            {
                Console.WriteLine("This is character");
            }
            else if(Value >= 48 && Value <= 57)
            {
                Console.WriteLine("This is integer");
            }
            else
            {
                Console.WriteLine("This special character");
            }

            Console.ReadLine();
        }
    }
}
