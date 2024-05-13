
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public Person(string name) : this(name, 0, "Empty")
    {
    }

    public Person(string name, int age) : this(name, age, "Empty")
    {
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Sex: {Gender}");
    }

    public bool IsAdult()
    {
        return Age >= 18;
    }

    public void ChangeName(string newName)
    {
        Name = newName;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Jack", 25, "man");
        Person person2 = new Person("Marry");
        Person person3 = new Person("John", 30);

        person1.PrintDetails();
        Console.WriteLine($"If is {person1.Name} adults? {person1.IsAdult()}\n");

        person2.PrintDetails();
        Console.WriteLine($"If is {person2.Name} adults? {person2.IsAdult()}\n");

        person3.PrintDetails();
        Console.WriteLine($"If is {person3.Name} adults? {person3.IsAdult()}\n");

        person1.ChangeName("Alex");
        Console.WriteLine("Updated information about the first person after the name change:");
        person1.PrintDetails();

        Console.ReadLine();
    }
}