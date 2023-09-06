using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusToFarenheitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
            /*What is the formula for C to F?
           To convert temperatures in degrees Celsius to Fahrenheit, multiply by 1.8 (or 9/5) and add 32.
            */
            //(32°F − 32) × 5/9 = 0°C

            int temp = 0;
            while (temp == 0)
            {
                Console.WriteLine("1.Enter Temperature in Celsius and Convert to Farenheit[Celsius To Farenheit]");
                decimal celsius = decimal.Parse(Console.ReadLine());

                decimal Farenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("Your body Temperature is " + Farenheit + "°F");

                Console.WriteLine();

                Console.WriteLine("2.Enter Temperature in Farenheit and Convert to Celsius [Farenheit to Celsius]");
                decimal far = decimal.Parse(Console.ReadLine());

                decimal cel =( far - 32) * 5 / 9;
                Console.WriteLine("Your Temperature is " + cel + "°C");

            }








            Console.ReadLine();
        }
        
    }
}
