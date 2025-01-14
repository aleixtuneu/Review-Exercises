﻿using MyLibrary;
namespace reviewexercises
{
    // Ex3
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceTemperature = "Introdueix la temperatura (Cº): ";
            const string MsgResult = "Temperatura en graus Fahrenheit (F): {0}.";
            const string MsgError = "Error. El valor ha de ser un número.";

            double celsiusInput = 0;

            Console.WriteLine(MsgIntroduceTemperature);
            while (!double.TryParse(Console.ReadLine(), out celsiusInput))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult, MyLibrary.MyMath.CelsiusToFahrenheit(celsiusInput));
        }
    }
}
