using FlashCards.DAO;
using FlashCards.Models;
using FlashCards.testDAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlashCardsTests
{
    [TestClass]
    public class VocabularyTests : BaseDaoTests
    {
        VocabularySqlDao vocabularyDao;
        [TestInitialize]
        public virtual void Init()
        {
            vocabularyDao = new VocabularySqlDao(connectionString);
        }

        [TestMethod]
        public void GetVocabularyByCategory()
        {
            string category = "dumb";
            List<Vocabulary> vocab = vocabularyDao.ListVocabularyByCategory(category);
            Assert.AreEqual(1, vocab.Count);
        }

        [TestMethod]
        public void GetVocabularyByCategoryBadCategory()
        {
            string category = "woohoo";
            List<Vocabulary> vocab = vocabularyDao.ListVocabularyByCategory(category);
            Assert.AreEqual(0, vocab.Count);
        }

        [TestMethod]
        public void ListVocabulary()
        {
            List<Vocabulary> vocab = vocabularyDao.ListVocabulary();
            Assert.AreEqual(2, vocab.Count);
        }

        [TestMethod]
        public void ListVocabularyCategories()
        {
            List<string> categories = vocabularyDao.ListVocabularyCategories();
            Assert.AreEqual(2, categories.Count);
        }

        [TestMethod]
        public void AddVocabulary()
        {
            string name = "alright";
            string category = "middle";
            string description = "this is an alright test";
            vocabularyDao.AddVocabulary(name, category, description);
            List<Vocabulary> vocab = vocabularyDao.ListVocabulary();
            Assert.AreEqual(3, vocab.Count);
        }
    }
}