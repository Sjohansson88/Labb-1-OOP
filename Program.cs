namespace Labb_1_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5.0);
            Circle circle2 = new Circle(6.0);

            Console.WriteLine("Arean på cirkeln med 5 cm i radie är: " + circle1.GetArea() + " cm²");
            Console.WriteLine("Arean på cirkeln med 6 cm i radie är: " + circle2.GetArea() + " cm²");

            Console.ReadKey();
        }
    }
    class Circle
    {
        
        int _Radius = 5 & 6;
        public Circle(double r)
        {
            _Radius = (int)r;
        }

        public double GetArea()
        {
            return Math.PI * _Radius * _Radius;
        }


    }
}