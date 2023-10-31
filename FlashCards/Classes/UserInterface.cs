using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.Classes
{
    public class UserInterface
    {
        string Conn = "Data Source=P137G001-LCR\SQLEXPRESS;Initial Catalog=FlashCards;Integrated Security=True"
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
                Console.WriteLine("2: Define application parameters");
                Console.WriteLine("3: Add new vocabulary");
                Console.WriteLine("4: View vocabulary list");
                Console.WriteLine("E: Exit");
                string response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "1":
                        BeginApplication();
                        break;
                    case "2":
                        DefineParameters();
                        break;
                    case "3":
                        AddVocabulary();
                        break;
                    case "4";
                        ViewVocabulary();
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

        private void AddVocabulary()
        {
            throw new NotImplementedException();
        }

        private void ViewVocabulary()
        {
            throw new NotImplementedException();
        }

        private void DefineParameters()
        {
            bool isFinished = false;
            while (!isFinished)
            {
                Console.WriteLine();
            }
            }

        private void BeginApplication()
        {
            throw new NotImplementedException();
        }
    }
}
