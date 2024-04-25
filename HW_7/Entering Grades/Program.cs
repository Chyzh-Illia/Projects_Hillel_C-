internal class EnteringGrades
{
    private static void Main(string[] args)
    {
        int numOfSubjects = 3;
 
        int[] grades = new int[numOfSubjects];
        string[] subjects = { "Mathematics", "History", "Language" };

        for (int i = 0; i < numOfSubjects; i++)
        {
            Console.Write($"Entering Grades from {subjects[i]}: ");
            grades[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The student's grades are entered:");
        for (int i = 0; i < numOfSubjects; i++)
        {
            Console.WriteLine($"{subjects[i]}: {grades[i]}");
        }

        double averageGrade = CalculateAverage(grades);

        Console.WriteLine($"Average grade of the student: {averageGrade}");

        Console.ReadLine();
    }

    static double CalculateAverage(int[] grades)
    {
        int sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }
        return (double)sum / grades.Length;
    }
}