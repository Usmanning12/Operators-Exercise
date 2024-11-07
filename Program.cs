namespace OperatorExercise
{
    public class Program
    {


        public static double AreaofCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);

        }

        

        static void Main(string[] args)
        {
            int a = 16;
            int b = 20;
            int c = 15;
            int d = 100;

            int sum = a + b;
            int subtraction = b + a;
            int mult = c * d;
            int quotient = d / c;
            int remainder = d % c;

            int e = ++a * d++;
            Console.WriteLine(e);
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            
            PrintAreaofCircle();
        }
        public static void PrintAreaofCircle()
        {
            Console.WriteLine("What is the area of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine(
                $"This is area of a circle with a radius of {radius} is {Math.Round(AreaofCircle(radius), 2)} ");
        }
    }
}
