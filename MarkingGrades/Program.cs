using System;

namespace MarkingGrades
{
    class Program
    {
        static void Main(string[] args)
        { 
            int number1;
        
            Console.WriteLine("please enter Total mark out of 100");
            number1 = Convert.ToInt32(Console.ReadLine());

            if (number1 >= 91 && number1 <= 100)
            {
                Console.WriteLine("A+");
            }
            if (number1 >= 81 && number1 <= 90) 
            {
                Console.WriteLine("A");
            }
            if (number1 >= 71 && number1 <= 80) 
            {
                Console.WriteLine("B");
            }
            if (number1 >= 60 && number1<= 70) 
            {
                Console.WriteLine("C");
            }
            if (number1 < 60) 
            {
                Console.WriteLine("F");
            }
        }
    }
}
}
