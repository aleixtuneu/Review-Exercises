using MyLibrary;
namespace reviewexercises
{
    // Ex9
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroducePrice = "Introdueix el preu: ";
            const string MsgError = "Error. El preu ha de ser un número positiu.";
            const string Msgresult = "20% de propina a deixar: {0}€.";

            double priceInput = 0;

            Console.WriteLine(MsgIntroducePrice);
            while (!double.TryParse(Console.ReadLine(), out priceInput) || priceInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(Msgresult, MyLibrary.MyMath.CalculateTip(priceInput));

        }
    }
}
