using MyLibrary;
namespace reviewexercises
{
    // Ex12
    public class Program
    {
        public static void Main()
        {
            const string MsgIntroduceSize = "Quants números vols introduir?";
            const string MsgIntroduceNumber = "Introdueix un número enter a la posició #{0}: ";
            const string MsgError = "Error. El valor ha de ser enter.";
            const string MsgOk = "L'array està ordenat ascendentment.";
            const string MsgKo = "L'array no està ordenat ascendentment.";

            int sizeInput = 0;
            int[] arrayInput;

            Console.WriteLine(MsgIntroduceSize);
            while (!int.TryParse(Console.ReadLine(), out sizeInput) || sizeInput <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            arrayInput = new int[sizeInput];

            for (int i = 0; i < arrayInput.Length; i++)
            {
                Console.WriteLine(MsgIntroduceNumber, i+1);
                while(!int.TryParse(Console.ReadLine(), out arrayInput[i]) || arrayInput[i] <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgError);
                }
                Console.WriteLine();
            }

            Console.WriteLine(MyLibrary.MyMath.IsSorted(arrayInput) ? MsgOk : MsgKo);
        }
    }
}
