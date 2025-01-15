using MyLibrary;
namespace reviewexercises
{
    // Ex10
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroducePrice = "Introdueix el preu: ";
            const string MsgIntroducePeopleNumber = "Introdueix el número de persones: ";
            const string MsgPriceError = "Error. El preu ha de ser un número positiu.";
            const string MsgPeopleError = "Error. El valor ha de ser un enter positiu.";
            const string Msgresult = "20% de propina a deixar per persona: {0}€.";

            double priceInput = 0;
            int peopleCountInput = 0;

            Console.WriteLine(MsgIntroducePrice);
            while (!double.TryParse(Console.ReadLine(), out priceInput) || priceInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgPriceError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgIntroducePeopleNumber);
            while (!int.TryParse(Console.ReadLine(), out peopleCountInput) || peopleCountInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgPeopleError);
            }
            Console.WriteLine();

            Console.WriteLine(Msgresult, MyLibrary.MyMath.CalculateTip(priceInput, peopleCountInput));
        }
    }
}
