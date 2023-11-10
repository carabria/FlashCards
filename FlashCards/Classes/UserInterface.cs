using FlashCards.DAO;
using FlashCards.Models;

namespace FlashCards.Classes
{
    public class UserInterface : ConsoleService
    {
        private readonly VocabularySqlDao vocabularySqlDao;
        public UserInterface()
        {
            vocabularySqlDao = new VocabularySqlDao("Server =.\\SQLEXPRESS; Database = FlashCards; Trusted_Connection = True");
        }

        // Menu methods

        public void DisplayMainMenu()
        {
            Console.WriteLine("1: Begin application");
            Console.WriteLine("2: Define application settings");
            Console.WriteLine("3: Edit vocabulary list");
            Console.WriteLine("4: View vocabulary list");
            Console.WriteLine("Press Enter: Exit");
        }

        public void DisplaySettingsMenu()
        {
            throw new NotImplementedException();
        }

        public void DisplayEditMenu()
        {
            Console.WriteLine("1: Add vocabulary");
            Console.WriteLine("2: Edit vocabulary");
            Console.WriteLine("3: Delete vocabulary term");
            Console.WriteLine("4: Delete vocabulary category");
            Console.WriteLine("Press Enter: Exit");
        }

        public void DisplayViewMenu()
        {
            Console.WriteLine("1: View all vocabulary");
            Console.WriteLine("2: View all vocabulary categories");
            Console.WriteLine("3: View a vocabulary by its ID");
            Console.WriteLine("4: View a vocabulary by its name");
            Console.WriteLine("Press Enter: Exit");
        }

        // Edit settings methods


        // Edit vocabulary methods

        public void AddVocabulary()
        {
            Console.WriteLine("Please enter in the name of the vocabulary.");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter in a category for the vocabulary.");
            string category = Console.ReadLine();

            Console.WriteLine("Please enter in a description of your vocabulary.");
            string description = Console.ReadLine();

            vocabularySqlDao.AddVocabulary(name, category, description);
        }

        public void EditVocabulary()
        {
            Console.WriteLine("Please enter in the ID of the vocabulary you would like to change.");
            string tempId = Console.ReadLine();
            int id = Convert.ToInt32(tempId);

            Console.WriteLine("Please enter in the new category for the vocabulary.");
            string category = Console.ReadLine();

            Console.WriteLine("Please enter in a description of your vocabulary.");
            string description = Console.ReadLine();
        }

        public void DeleteVocabularyById()
        {
            throw new NotImplementedException();
        }

        public void DeleteVocabularyByCategory()
        {
            throw new NotImplementedException();
        }

        // View vocabulary methods

        public void ViewAllVocabulary()
        {
            List<Vocabulary> vocab = vocabularySqlDao.ListVocabulary();
            foreach (Vocabulary vocabulary in vocab)
            {
                Console.WriteLine($"{vocabulary.Id}, {vocabulary.Name}, {vocabulary.Category}, {vocabulary.Description}");
            }
        }

        public void ViewVocabularyCategories()
        {
            List<string> categories = vocabularySqlDao.ListVocabularyCategories();
            Console.WriteLine();
            foreach (string category in categories)
            {
                Console.WriteLine(category);
            }
            Console.WriteLine();
        }

        public void ViewVocabularyById()
        {
            throw new NotImplementedException();
        }

        internal void ViewVocabularyByName()
        {
            throw new NotImplementedException();
        }
    }
}
