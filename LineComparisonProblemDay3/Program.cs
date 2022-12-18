namespace LineComparisonProblemDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcomw! to Line Comparison Pragram");
            Console.WriteLine("Please enter X1 and Y1 coordinates");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X2 and Y2 coordinates");
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());
            double temp1 = Math.Pow((X2 - X1), 2);
            double temp2 = Math.Pow((Y2 - Y1), 2);
            double result = Math.Sqrt(temp1 + temp2);
            Console.WriteLine("The length of line is:" + result);
        }
    }
}