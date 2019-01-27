using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //staticly typed language 

            Random randomNumber = new Random();

            int firstNumber = randomNumber.Next(2, 10);
            int secondNumber = randomNumber.Next(2,10);

            var substraction = randomNumber.Next(2,10);

            int answer;

            string promp = ". Don't type in the answer, just Press ENTER when ready";

            Console.WriteLine("Think of a number between 1 and 10" + promp);
            Console.ReadKey();
            Console.WriteLine("Multiply your number by " + firstNumber + promp);
            Console.ReadKey();
            Console.WriteLine("Now multiply the result by " + secondNumber + promp);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you originally thought of" + promp);
            Console.ReadKey();
            Console.WriteLine("Now substract 7" + promp);
            Console.ReadKey();

            answer = firstNumber * secondNumber -7;
            Console.WriteLine("The answer is " + answer);
        }
    }
}
