using MyLibrary;
namespace reviewexercises
{
    // Ex5
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceTemperature = "Introdueix la temperatura (Kº): ";
            const string MsgResult = "Temperatura en graus Fahrenheit (Fº): {0}.";
            const string MsgError = "Error. El valor ha de ser un número.";

            double kelvinInput = 0;

            Console.WriteLine(MsgIntroduceTemperature);
            while (!double.TryParse(Console.ReadLine(), out kelvinInput))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult, MyLibrary.MyMath.KelvinToFahrenheit(kelvinInput));

        }
    }
}
