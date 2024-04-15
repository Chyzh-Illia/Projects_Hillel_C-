internal class Seasons
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the month number:");
        int month = Convert.ToInt32(Console.ReadLine());

        string season;

        switch (month)
        {
            case 1:
            case 2:
            case 12:
                season = "Winter";
                break;
            case 3:
            case 4:
            case 5:
                season = "Spring";
                break;
            case 6:
            case 7:
            case 8:
                season = "Summer";
                break;
            case 9:
            case 10:
            case 11:
                season = "Autumn";
                break;
            default:
                season = "There is no such moon on this planet";
                break;
        }

        Console.WriteLine("Сезон: " + season);
    }
}