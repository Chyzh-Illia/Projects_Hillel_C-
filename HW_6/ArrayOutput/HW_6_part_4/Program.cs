public class Program
{
    public static void Main(string[] args)
    {
        Random rand = new Random();

        int[] array = new int[20];

        Console.Write("Array: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-5, 6);
            Console.Write(array[i] + " ");

            if (array[i] == -1)
            {
                break;
            }
        }
        Console.WriteLine();
    }
}