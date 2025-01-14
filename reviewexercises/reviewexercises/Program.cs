using MyLibrary;
namespace reviewexercises
{
    // Ex8
    public class Program
    {
        public static void Main()
        {
            const string MsgInput = "Introdueix un codi postal: ";
            const string MsgOk = "És un codi postal.";
            const string MsgKo = "No és un codi postal.";

            string postalCodeInput = "";

            Console.WriteLine(MsgInput);
            Console.WriteLine(MyLibrary.MyMath.ValidatePostalCode(postalCodeInput) ? MsgOk : MsgKo);

        }
    }
}
