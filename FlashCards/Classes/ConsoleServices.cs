using FlashCards.DAO;
using FlashCards.Models;

namespace FlashCards.Classes
{
    public class ConsoleServices
    {
        private readonly VocabularySqlDao vocabularySqlDao;
        public ConsoleServices()
        {
            vocabularySqlDao = new VocabularySqlDao("Server =.\\SQLEXPRESS; Database = FlashCards; Trusted_Connection = True");
        }

        public void BeginApplication()
        {
            List<Vocabulary> vocab = vocabularySqlDao.ListVocabulary();
            for (int i = 0; i < vocab.Count; i++)
            {
                Console.WriteLine($"Question {i}: {vocab[i]}");
            }
        }

        public void DefineSettings()
        {
            bool isFinished = false;
            while (!isFinished)
            {
                Console.WriteLine();
            }
        }

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

        public void ViewVocabulary()
        {
            bool isFinished = false;
            while (!isFinished)
            {
                Console.WriteLine("Please make an entry");
                Console.WriteLine("1: View all vocabulary");
                Console.WriteLine("2: View vocabulary categories");
                Console.WriteLine("E: Exit");
                string response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "1":
                        ShowAllVocabulary();
                        break;
                    case "2":
                        ShowVocabularyCategories();
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
        private void ShowAllVocabulary()
        {
            List<Vocabulary> vocab = vocabularySqlDao.ListVocabulary();
            foreach (Vocabulary vocabulary in vocab)
            {
                Console.WriteLine($"{vocabulary.Id}, {vocabulary.Name}, {vocabulary.Category}, {vocabulary.Description}");
            }
        }

        private void ShowVocabularyCategories()
        {
            List<string> categories = vocabularySqlDao.ListVocabularyCategories();
            Console.WriteLine();
            foreach (string category in categories)
            {
                Console.WriteLine(category);
            }
            Console.WriteLine();
        }
    }
}
