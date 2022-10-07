using DayOfTheWeekApp.Core;
using DayOfTheWeekApp.Core.Enums;

namespace DayOfTheWeekApp
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBirth { get; set; }

        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApplication()
        {
            Console.WriteLine("Hey, Jestem botem, ktory potrafi wyliczac dzien tygodnia na podstawie Twojej daty urodzenia");
            
            Calculator = new DayCalculator();
        }

        public void AskUserForTheirDateOfBirth()
        {
            Console.WriteLine("Podaj mi prosze swoja date urodzenia");
            var userDate = Console.ReadLine();

            var succeded = DateTimeOffset.TryParse(userDate, out var date);
            
            if (succeded)
            {
                UserDateOfBirth = date;
                return;
            }
            Console.WriteLine("Format daty byl zly, Prosze go podac w dd/mm/yyyy");
            AskUserForTheirDateOfBirth();
        }

        public DayCalculator GetCalculator()
        {
            return Calculator;
        }

        public void CalculateDayOfTheWeek(DayCalculator calculator)
        {
            if (UserDateOfBirth == null)
            {
                Console.WriteLine("Probowano obliczyc dzien tygodnia bez podania daty urodzenia");
                return;
            }

            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        }

        public void PrintDayOfTheWeek()
        {
            Console.WriteLine("Obliczony dzien tygodnia to: " + UserDayOfTheWeek.ToPolishString());
        }

    }
}
