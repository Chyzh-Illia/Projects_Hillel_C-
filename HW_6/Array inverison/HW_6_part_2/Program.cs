internal class InversionArray
{
    private static void Main(string[] args)
    {
        int[] array = { 5, -9, 8, 7 };

        
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = temp;
        }

        
        Console.Write("Inverted array (method 2): ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}