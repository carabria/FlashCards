using FlashCards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.DAO.Interfaces
{
    public interface IVocabularyDAO
    {
        public List<Vocabulary> ListVocabulary();
    }
}
