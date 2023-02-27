using System.Xml.Linq;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz("Dav").PrintToConsole();

            FizzBuzz(12345).PrintToConsole();

            FizzBuzz("DavidChuvikcool").PrintToConsole();

        }



        public static string FizzBuzz<T>(T item)
        {
            int itemLength = item.ToString().Length;
            string result = "";

            if (itemLength % 3 == 0)
            {
                result += "Fizz";
            }
            if (itemLength % 5 == 0)
            {
                result += "Buzz";
            }
            return result;
        }
    }

    public static class ExtensionsClass
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message.ToString());
        }
    }
}
    
