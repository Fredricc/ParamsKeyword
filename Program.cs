namespace ParamsKeyword
{
    public class NumberPrinter
    {
        public void PrintNumber(params int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberPrinter = new NumberPrinter();
            numberPrinter.PrintNumber(new int[] {1,2,3,4,5});
            Console.WriteLine();
            numberPrinter.PrintNumber(1,3,4,5,100);

            
        }
    }
}