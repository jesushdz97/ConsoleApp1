using ConsoleApp1.Service;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate string SimpleDelegate(string text);

        private static void Main()
        {
            SimpleDelegate simpleDelegate = ToUpperText;
            ExecuteSimpleDelegate(simpleDelegate, "Jesús Hernández");

            Console.WriteLine("");
            Func<string, string> funcDelegateFunc = ToUpperText;
            ExecuteFunc(funcDelegateFunc, "Jesús Hernández");

            Console.WriteLine("");
            Action<string, string> action = ConcatTextAction;
            ExecuteAction(action, "Jesús", "Hernández");
        }

        public static string ToUpperText(string text)
        {
            return text.ToUpper();
        }

        public static void ConcatTextAction(string textOne, string textTwo)
        {
            Console.WriteLine(textOne + " " + textTwo);
        }

        public static void ExecuteSimpleDelegate(SimpleDelegate @delegate, string text)
        {
            Console.WriteLine("SimpleDelegate Example");
            Console.WriteLine(@delegate(text));
            Console.WriteLine("SimpleDelegate Example");
        }

        public static void ExecuteFunc(Func<string, string> @func, string text)
        {
            Console.WriteLine("Func Example");
            Console.WriteLine(@func(text));
            Console.WriteLine("Func Example");
        }

        public static void ExecuteAction(Action<string, string> @action, string textOne, string textTwo)
        {
            Console.WriteLine("Action Example");
            @action(textOne, textTwo);
            Console.WriteLine("Action Example");
        }
    }
}
