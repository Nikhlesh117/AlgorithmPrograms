using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class FindYourNumber
    {
        public void Find()
        {
            int Start, End;

            Console.Write("Enter start of the range : ");
            Start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter end of the range : ");
            End = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int lower = Start, higher = End;
            int middle = (lower + higher) / 2;

            while (true)
            {
                if (lower == higher)
                {
                    return;
                }
                Console.WriteLine("1. Your number is greater than " + middle);
                Console.WriteLine("2. Your number is less than " + middle);
                Console.WriteLine("3. Your number is : " + middle);
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        lower = middle;
                        break;
                    case 2:
                        higher = middle;
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Please enter correct choice");
                        break;
                }
                middle = (lower + higher) / 2;
            }
        }
    }
}
