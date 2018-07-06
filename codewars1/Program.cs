using System;

namespace codewars1
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = CreatePhoneNumber(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9});

            Console.WriteLine(phoneNumber);
            Console.ReadKey();

        }



        public static string CreatePhoneNumber(int[] numbers)
        {

            //int[] test = { 1, 2, 2, 2, 2 };
            //Console.WriteLine(test.ToString());
            //Console.ReadLine();
            //Console.WriteLine(numbers.ToString());
            //var numbersString = "";
            //foreach(var num in numbers)
            //   numbersString += num;
            //var numberInt = decimal.Parse(numbersString);
            //string formatedNumber = string.Format("{0:(###) ###-####}", numberInt);
            string x = string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);


            //string formattedNumber = string.Format("{0:(###) ###-####}", 1234567890);
            Console.WriteLine(x);
            Console.ReadLine();

            //foreach (string number in numbers){

            //}
            //string formatedNumber;
            //formatedNumber = ("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);
            return x;
        }
    }
}