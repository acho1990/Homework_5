using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Homework1

            Console.WriteLine("Please, enter number");
            var num = Console.ReadLine();
            var parseNum = Convert.ToDecimal(num);
            if (parseNum % 5 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }

            #endregion Homework1


            #region Homework2 

            Console.WriteLine("Calculate the sum of two numbers.");
            var number = Console.ReadLine();
            var number2 = Console.ReadLine();
            var sum = Convert.ToDecimal(number) + Convert.ToDecimal(number2);
            Console.WriteLine($"The sum of two numbers is: {sum}");


            Console.WriteLine("Calculate the difference of two numbers.");
            var difference = Convert.ToDecimal(number) - Convert.ToDecimal(number2);
            if (difference < 0)
            {
                difference = -difference;
            }
            Console.WriteLine($"The difference of two numbers is: {difference}");


            Console.WriteLine("Multiply two numbers..");
            var multiply = Convert.ToDecimal(number) * Convert.ToDecimal(number2);
            Console.WriteLine($"The multiply of two numbers is: {multiply}");



            Console.WriteLine("Divide two numbers..");
            var divide = Convert.ToDecimal(number) / Convert.ToDecimal(number2);
            if (number2 == "0")
            {
                Console.WriteLine("Not Allowed To Divide By Zero");
            }
            else
            {
                Console.WriteLine($"The divide of two numbers is: {divide}");
            }

            #endregion Homework2



            #region Homework3

            Console.WriteLine("Swap values ​​between two variables");
            var x = Console.ReadLine();
            var y = Console.ReadLine();
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            Console.WriteLine($"After Swap: x = {y}, y = {x}");


            #endregion  Homework3



            #region Homework4 - Loops


            Console.WriteLine("Enter Number");
            var number3 = Console.ReadLine();
            var parseNum3 = Convert.ToDecimal(number3);
            var n = 0;
            while (n < 10)
            {
                n++;
                var result = parseNum3 * n;
                Console.WriteLine($"{parseNum3} * {n} = {result}");
            }



            #endregion Homework4 - Loops




            #region Homework5 

            Console.WriteLine("Enter Number");
            var number4 = Console.ReadLine();
            var parseNum4 = Convert.ToDecimal(number4);
            var N = 0;
            while (N < parseNum4)
            {
                N++;
                if (N % 2 == 0)
                {
                    Console.WriteLine(N * N);
                }
            }




            #endregion Homework5 











































        }
    }
}
