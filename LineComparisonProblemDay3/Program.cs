namespace LineComparisonProblemDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter X3 and Y3 coordinates");
            var X3 = Convert.ToDouble(Console.ReadLine());
            var Y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X4 and Y4 coordinates");
            var X4 = Convert.ToDouble(Console.ReadLine());
            var Y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X5 and Y5 coordinates");
            var X5 = Convert.ToDouble(Console.ReadLine());
            var Y5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter X6 and Y6 coordinates");
            var X6 = Convert.ToDouble(Console.ReadLine());
            var Y6 = Convert.ToDouble(Console.ReadLine());

            double temp1 = Math.Pow((X4 - X3), 2);
            double temp2 = Math.Pow((Y4 - Y3), 2);
            double Length1 = Math.Sqrt(temp1 + temp2);
            Console.WriteLine("Length of line1:" + Length1);

            double temp3 = Math.Pow((X6 - X5), 2);
            double temp4 = Math.Pow((Y6 - Y5), 2);
            double Length2 = Math.Sqrt(temp3 + temp4);
            Console.WriteLine("Length of line2:" + Length2);

            if (Length1 == Length2)
            {
                Console.WriteLine("Lenght of two lines are equal");
            }
            else
            {
                Console.WriteLine("Lenght of two lines are not equal");
            }
        }
    }
}