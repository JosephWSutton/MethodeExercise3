using System;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = -1000;
            int ceiling = 1000;

            PrintRange(floor, ceiling);

            ByThrees();

            Console.WriteLine("Enter a number to check if even or odd");

            OddOrEven(4);

            PosOrNeg(55);

            AreSame(54,54);

            Console.WriteLine("How old are you?");

            int age = (int.Parse(Console.ReadLine()));

            CanVote(age);

            Console.WriteLine("Enter a number to check if in between -10 and 10");

            int betweenTens = (int.Parse(Console.ReadLine()));

            InBetweenTens(betweenTens);

            Console.Write("Input a number to see its multiplication table: ");
            int num1;
            int.TryParse(Console.ReadLine(), out num1);
            Table(num1);
        }

        public static void Table(int a)
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{a} * {i} = {a * i}");
            }
        }


        public static bool InBetweenTens(int a)
        {
            if (a <= 10 && a >= -10)
            {
                Console.WriteLine("The number is in between tens!");
                return true;
            }
            Console.WriteLine("The number is not in between tens!");
            return false;
        }




        public static void PrintRange(int floor, int ceiling)
        {
            for(int i = floor; i <= ceiling; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void ByThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool AreSame(int a, int b)
        {
            if(a == b)
            {
                return true;
            }
            return false;
        }

        public static void OddOrEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }

        }

        public static void PosOrNeg(int a)
        {
            if(a > 0)
            {
                Console.WriteLine($"{a} is a positive number!");
            }
            else if(a < 0)
            {
                Console.WriteLine($"{a} is a negative number");
            }
            else
            {
                Console.WriteLine($"{a} is zero");
            }
        }

        public static void CanVote(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote.");
            }
        }

     

    }
}
