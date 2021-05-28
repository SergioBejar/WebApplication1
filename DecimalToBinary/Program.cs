using System;
using System.Text.RegularExpressions;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            int decimalNumber;
            int temp;
            int[] binary = new int[10];

            inputValue = Console.ReadLine().Trim();

            Regex regex = new Regex("^[0-9]+$");

            if (!regex.IsMatch(inputValue))
            {
                Console.WriteLine("Entrada no valida");
                return;
            }

            decimalNumber = int.Parse(inputValue);
            for (temp = 0; decimalNumber > 0; temp++)
            {
                binary[temp] = decimalNumber % 2;
                decimalNumber /= 2;
            }
            for (temp--; temp >= 0; temp--)
            {
                Console.Write(binary[temp]);
            }
        }
    }
}
