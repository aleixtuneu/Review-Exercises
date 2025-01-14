using MyLibrary;
namespace reviewexercises
{
    // Ex6
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroducePrice = "Introdueix el preu: ";
            const string MsgIntroduceDiscountedPrice = "Introdueix el preu amb descompte: ";
            const string MsgResult = "Descompte: {0}%";
            const string MsgError = "Error. El valor ha de ser un número positiu: ";

            double priceInput = 0;
            double discountedPriceInput = 0;

            Console.WriteLine(MsgIntroducePrice);
            while (!double.TryParse(Console.ReadLine(), out priceInput) || priceInput <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgIntroduceDiscountedPrice);
            while (!double.TryParse(Console.ReadLine(), out discountedPriceInput) || discountedPriceInput <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult, MyLibrary.MyMath.CalculateDiscount(priceInput, discountedPriceInput));
        }
    }
}
