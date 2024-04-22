public class ArrayRandom
{
    public static void Main(string[] args)
    {
        Random rand = new Random();

        int[] array = new int[10];

        Console.Write("Array to add element: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 101);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int newElement = rand.Next(-100, 101);
        Console.WriteLine("The element we add to the array: " + newElement);

        int[] newArray = new int[array.Length + 1];

        newArray[0] = newElement;

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        Console.Write("Array after adding an element: ");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.Write(newArray[i] + " ");
        }
        Console.WriteLine();
    }
}