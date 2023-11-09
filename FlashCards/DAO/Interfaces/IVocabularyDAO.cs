using FlashCards.Models;

namespace FlashCards.DAO.Interfaces
{
    public interface IVocabularyDAO
    {
        public List<Vocabulary> ListVocabulary();

        public List<string> ListVocabularyCategories();

        public List<Vocabulary> ListVocabularyByCategory(string category);

        public void AddVocabulary(string name, string category, string description);
    }
}
