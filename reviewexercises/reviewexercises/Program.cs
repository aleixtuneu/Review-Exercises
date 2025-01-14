using MyLibrary;
namespace reviewexercises
{
    // Ex7
    public class Program
    {
        public static void Main()
        {
            const string MsgInputDecimalNumber = "Introdueix un número en base decimal: ";
            const string MsgResult = "Número en base hexadecimal: {0}";
            const string MsgError = "Error. El valor ha de ser un enter positiu.";

            int decimalNumberInput = 0;

            Console.WriteLine(MsgInputDecimalNumber);
            while (!int.TryParse(Console.ReadLine(), out decimalNumberInput) || decimalNumberInput <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult, MyLibrary.MyMath.DecimalToHexadecimal(decimalNumberInput));

        }
    }
}
