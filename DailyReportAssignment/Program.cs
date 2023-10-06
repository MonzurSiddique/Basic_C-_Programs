using System;


namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int PageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"."); //true = yes, false = no;
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            Console.WriteLine("Were there any positive experience you'd like to share? Please give specifics.");
            string PositiveExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string StudyHours = Console.ReadLine();
            int StudyHoursNum = Convert.ToInt32((StudyHours));
            Console.WriteLine("Thank you for your answer. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
