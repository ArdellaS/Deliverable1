
using System;

namespace Lab1
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            double FirstAmount;
            double SecondAmount;
            double ThirdAmount;
            double Average;
            double Smallest;
            double Largest;
            double Total;

            Console.WriteLine("Enter a dollar amount:");
            FirstAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second dollar amount:");
            SecondAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the third dollar amount:");
            ThirdAmount = Convert.ToDouble(Console.ReadLine());

            Average = (FirstAmount + SecondAmount + ThirdAmount) / 3;

            Console.WriteLine("The average amount is: $" + Average);

            if (FirstAmount < SecondAmount && FirstAmount < ThirdAmount)
            {
                Smallest = FirstAmount;
            }
            else if (SecondAmount < FirstAmount && SecondAmount < ThirdAmount)
            {
                Smallest = SecondAmount;
            }
            else
            {
                Smallest = ThirdAmount;
            }

            Console.WriteLine("The smallest amount is: $" + Smallest);


            if (FirstAmount > SecondAmount && FirstAmount > ThirdAmount)
            {
                Largest = FirstAmount;
            }
            else if (SecondAmount > FirstAmount && SecondAmount > ThirdAmount)
            {
                Largest = SecondAmount;
            }
            else
            {
                Largest = ThirdAmount;
            }
            Console.WriteLine("The largest amount is: $" + Largest);

            Total = FirstAmount + SecondAmount + ThirdAmount;



            Console.WriteLine(" ");

            Console.WriteLine("The amount of dollars in USD is $" + Total);
            Console.WriteLine("The amount of dollars in Swedish Krona is " + Total * 9.26
                 + "kr");
            Console.WriteLine("The amount of dollars in Japanese Yenn is ¥" + Total * 111.48);
            Console.WriteLine("The amount of dollars in Thai Baht is ฿" + Total * 31.73);
            Console.Read();
        }
    }
}

