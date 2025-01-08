using MyLibrary;
namespace reviewexercises
{
    public class Program
    {
        public static void Main()
        {
            const string MsgHello = "Introdueix un número en segons: ";
            const string MsgError = "Error. El número ha de ser un enter positiu.";
            const string MsgResult = "Resultat: ";

            int secondsInput = 0;

            Console.WriteLine(MsgHello);
            while (!int.TryParse(Console.ReadLine(), out secondsInput) || secondsInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult + MyLibrary.MyMath.SecondsToHoursAndMinutes(secondsInput));
        }
    }
}
