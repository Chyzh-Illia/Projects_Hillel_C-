internal class Array
{
    private static void Main(string[] args)
    {
        Random rand = new Random();

        int[] array = new int[10];

        Console.Write("Array: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-100, 101);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int positiveCount = 0;
        foreach (int num in array)
        {
            if (num > 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine("Number of positive numbers: " + positiveCount);
    }
}