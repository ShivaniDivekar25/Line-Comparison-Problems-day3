namespace LineComparisonProblemDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter X1 and Y1 coordinates");
            var X1 = Convert.ToDouble(Console.ReadLine());
            var Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X2 and Y2 coordinates");
            var X2 = Convert.ToDouble(Console.ReadLine());
            var Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X3 and Y3 coordinates");
            var X3 = Convert.ToDouble(Console.ReadLine());
            var Y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X4 and Y4 coordinates");
            var X4 = Convert.ToDouble(Console.ReadLine());
            var Y4 = Convert.ToDouble(Console.ReadLine());

            double temp1 = Math.Pow((X2 - X1), 2);
            double temp2 = Math.Pow((Y2 - Y1), 2);
            double LengthOfFirstLine = Math.Sqrt(temp1 + temp2);

            double temp3 = Math.Pow((X4 - X3), 2);
            double temp4 = Math.Pow((Y4 - Y3), 2);
            double LengthOfSecondLine = Math.Sqrt(temp3 + temp4);
            Console.WriteLine("The length of Line1 {0}. \n And length of Line2 {1}:", LengthOfFirstLine, LengthOfSecondLine);

            if (LengthOfFirstLine == LengthOfSecondLine)
            {
                Console.WriteLine("Lenght of two lines are equal");
            }
            else if (LengthOfFirstLine > LengthOfSecondLine)
            {
                Console.WriteLine("Lenght of line1 is greater than length of line2");
            }
            else
            {
                Console.WriteLine("Length of line1 is smaller than length of line2");
            }
        }
    }
}