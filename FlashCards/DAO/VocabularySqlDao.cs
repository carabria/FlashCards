using FlashCards.DAO.Interfaces;
using FlashCards.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards.DAO
{
    public class VocabularySqlDao : IVocabularyDAO
    {
        private string connectionString = "";
        private string sqlListVocabulary = "SELECT id, name, category, description FROM cards;";
        public VocabularySqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<Vocabulary> ListVocabulary()
        {
            List<Vocabulary> vocabulary = new List<Vocabulary>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlListVocabulary, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Vocabulary vocab = new Vocabulary();
                            vocab = MapRowToVocabulary(reader);
                            vocabulary.Add(vocab);
                        }
                    }
                }
            }
            return vocabulary;
        }
        private Vocabulary MapRowToVocabulary(SqlDataReader reader)
        {
            Vocabulary vocab = new Vocabulary();
            vocab.Id = Convert.ToInt32(reader["id"]);
            vocab.Name = Convert.ToString(reader["name"]);
            vocab.Category = Convert.ToString(reader["category"]);
            vocab.Description = Convert.ToString(reader["category"]);
            return vocab;
        }
    }
}
