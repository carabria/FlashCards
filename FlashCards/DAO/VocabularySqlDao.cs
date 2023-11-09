using FlashCards.DAO.Interfaces;
using FlashCards.Exceptions;
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

        public List<string> ListVocabularyCategories()
        {
            List<string> categories = new List<string>();
            string sql = "SELECT category FROM cards GROUP BY category";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            string category = Convert.ToString(reader["category"]);
                            categories.Add(category);
                        }
                    }
                }
            }
            return categories;
        }

        public List<Vocabulary> ListVocabularyByCategory(string category)
        {
            List<Vocabulary> vocabularies = new List<Vocabulary>();
            string sql = "SELECT id, name, category, description FROM cards WHERE category = @category";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@category", category);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            Vocabulary vocabulary = MapRowToVocabulary(reader);
                            vocabularies.Add(vocabulary);
                        }
                    }
                }
            }
            return vocabularies;
        }

        public void AddVocabulary(string name, string category, string description)
        {
            string sql = "INSERT INTO cards(name, caregory, description) " +
                "OUTPUT INSERTED.id " +
                "VALUES (@name, @category, @description)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // create user
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                throw new DaoException("SQL exception occurred", ex);
            }
        }

        private Vocabulary MapRowToVocabulary(SqlDataReader reader)
        {
            Vocabulary vocab = new Vocabulary();
            vocab.Id = Convert.ToInt32(reader["id"]);
            vocab.Name = Convert.ToString(reader["name"]);
            vocab.Category = Convert.ToString(reader["category"]);
            vocab.Description = Convert.ToString(reader["description"]);
            return vocab;
        }
    }
}
