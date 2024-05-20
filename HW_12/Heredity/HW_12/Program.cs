using System;

class Transport
{
    public string Name { get; set; }
    public int MaxSpeed { get; set; }

    public Transport(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} is moving at a speed of {MaxSpeed} km/h.");
    }
}

class Car : Transport
{
    public int NumberOfDoors { get; set; }

    public Car(string name, int maxSpeed, int numberOfDoors)
        : base(name, maxSpeed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} with {NumberOfDoors} doors is moving at a speed of {MaxSpeed} km/h.");
    }
}

class Bicycle : Transport
{
    public string BicycleType { get; set; }

    public Bicycle(string name, int maxSpeed, string bicycleType)
        : base(name, maxSpeed)
    {
        BicycleType = bicycleType;
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} ({BicycleType}) is moving at a speed of {MaxSpeed} km/h.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("BMW", 250, 4);
        Bicycle bicycle = new Bicycle("Giant", 25, "Mountain");

        car.Move();
        bicycle.Move();

        Console.ReadKey();
    }
}