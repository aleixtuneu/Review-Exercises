using MyLibrary;
namespace reviewexercises
{
    // Ex11
    public class Program
    {
        public static void Main()
        {
            const string MsgInputNumber = "Introdueix un número enter: ";
            const string MsgError = "Error. El valor ha de ser enter.";
            const string MsgResult = "Número de dígits del número introduït: {0}";

            int numberInput = 0;

            Console.WriteLine(MsgInputNumber);
            while (!int.TryParse(Console.ReadLine(), out numberInput))
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult, MyLibrary.MyMath.CountDigits(numberInput));
        }
    }
}
