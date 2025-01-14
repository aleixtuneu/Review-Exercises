using MyLibrary;
namespace reviewexercises
{
    public class Program
    {
        public static void Main()
        {
            // 2
            Exercise2();
        }

        public static void Exercise2()
        {
            const string MsgBase = "Introdueix la base: ";
            const string MsgHeight = "Introdueix la altura: ";
            const string MsgResult = "Resultat: ";
            const string MsgError = "Error. El valor ha de ser positiu.";

            float baseInput = 0.0f;
            float heightInput = 0.0f;

            Console.WriteLine(MsgBase);
            while (!float.TryParse(Console.ReadLine(), out baseInput) || baseInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgHeight);
            while (!float.TryParse(Console.ReadLine(), out heightInput) || heightInput < 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            Console.WriteLine(MsgResult + MyLibrary.MyMath.CalculateTriangleArea(baseInput, heightInput));
        }
    }
}
