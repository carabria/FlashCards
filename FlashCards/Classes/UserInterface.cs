using FlashCards.DAO;

namespace FlashCards.Classes
{
    public class UserInterface
    {
        private readonly VocabularySqlDao vocabularySqlDao;
        private readonly ConsoleServices consoleServices;
        public UserInterface()
        {
            consoleServices = new ConsoleServices();
        }
        public void Run()
        {
            Console.WriteLine("Welcome to the flash card application. Good luck with your studies!");
            Console.WriteLine();
            DisplayMenu();
        }

        private void DisplayMenu()
        {
            bool isFinished = false;
            while (!isFinished)
            {
                Console.WriteLine("Please make an entry");
                Console.WriteLine("1: Begin application");
                Console.WriteLine("2: Define application settings");
                Console.WriteLine("3: Add new vocabulary");
                Console.WriteLine("4: View vocabulary list");
                Console.WriteLine("E: Exit");
                string response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "1":
                        consoleServices.BeginApplication();
                        break;
                    case "2":
                        consoleServices.DefineSettings();
                        break;
                    case "3":
                        consoleServices.AddVocabulary();
                        break;
                    case "4":
                        consoleServices.ViewVocabulary();
                        break;
                    case "E":
                        isFinished = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid character.");
                        break;
                }
            }
        }
    }
}
