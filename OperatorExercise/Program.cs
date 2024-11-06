using System.Threading.Channels;

namespace OperatorExercise
{
    public class Program
    {
        
        public static double AreaofCircle(double radius)
        {
            return Math.PI * Math.Pow(radius,2);
        }

        public static void PrintAreaofCircle()
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"This area of a circle with a radius of {radius} is {Math.Round(AreaofCircle(radius),2)}");
        }
        static void Main(string[] args) 
        {
           int  a = 17;
           int  b = 4;

           int sum = a + b;
           int subtraction = a - b;
           int mult = a * b;
           int quotient = a / b;
           int remainder = a % b; 
           
           Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

           PrintAreaofCircle();
           



        }
    }
}
