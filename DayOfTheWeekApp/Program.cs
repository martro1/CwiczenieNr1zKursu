using DayOfTheWeekApp;
using DayOfTheWeekApp.Core;
class Program
{
    static void Main(string[] args)
    {
        var guesser = new DayGuesser();
        guesser.IntroduceTheApplication();
        guesser.AskUserForTheirDateOfBirth();
        guesser.CalculateDayOfTheWeek(guesser.GetCalculator());
        guesser.PrintDayOfTheWeek();
    }
}
