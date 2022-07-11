namespace Zadanie4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string number = (string.Join(" ", args));
            if (number.Contains("."))
            {
                number = number.Replace(".", "");
            }
            else if (number.Contains(","))
            {
                number = number.Replace(",", "");
            }
            Console.WriteLine(number.Length);
        }
    }
}