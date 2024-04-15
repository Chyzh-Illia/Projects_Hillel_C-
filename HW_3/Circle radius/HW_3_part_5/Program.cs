internal class CircleRadius
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("Area of ​​a circle with radius {0} is equal to {1}", radius, area);
    }
}