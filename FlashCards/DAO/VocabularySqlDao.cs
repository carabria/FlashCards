﻿using FlashCards.DAO.Interfaces;
using FlashCards.Exceptions;
using FlashCards.Models;
using System.Data.SqlClient;

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

        // Edit methods
        public void AddVocabulary(string name, string category, string description)
        {
            string sql = "INSERT INTO cards(name, category, description) " +
                "OUTPUT INSERTED.id " +
                "VALUES (@name, @category, @description)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@description", description);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        throw new DaoException("No vocabulary was added.");
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DaoException("A SQL exception occurred", ex);
            }
        }

        public void EditVocabulary(int id, string? name, string? category, string? description)
        {
            Vocabulary vocab = new Vocabulary();
            Vocabulary oldVocab = GetVocabularyById(id);
            string sql = "UPDATE cards SET name = @name, category = @category, description = @description WHERE id = @id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        if (string.IsNullOrEmpty(name))
                        {
                            cmd.Parameters.AddWithValue("@name", oldVocab.Name);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                        }

                        if (string.IsNullOrEmpty(category))
                        {
                            cmd.Parameters.AddWithValue("@category", oldVocab.Category);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@category", category);
                        }

                        if (string.IsNullOrEmpty(description))
                        {
                            cmd.Parameters.AddWithValue("@description", oldVocab.Description);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@description", description);
                        }
                        cmd.ExecuteScalar();
                    }
                }
            }

            catch (SqlException ex)
            {
                throw new DaoException("A SQL exception occurred", ex);
            }
        }

        public void DeleteVocabulary(int id)
        {
            string sql = "DELETE FROM cards WHERE id = @id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteScalar();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DaoException("A SQL exception occurred", ex);
            }
        }

        // View Methods

        public Vocabulary GetVocabularyById(int id)
        {
            Vocabulary vocab = new Vocabulary();
            string sql = "SELECT id, name, category, description FROM cards WHERE id = @id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                vocab = MapRowToVocabulary(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new DaoException("A SQL exception occurred", ex);
            }
            return vocab;
        }

        public List<Vocabulary> ListVocabulary()
        {
            List<Vocabulary> vocabulary = new List<Vocabulary>();
            try
            {
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
            }
            catch (SqlException ex)
            {
                throw new DaoException("A SQL exception occurred", ex);
            }
            return vocabulary;
        }

        public List<string> ListVocabularyCategories()
        {
            List<string> categories = new List<string>();
            string sql = "SELECT category FROM cards GROUP BY category";
            try
            {
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
            }
            catch (SqlException ex)
            {
                throw new DaoException("A SQL exception occurred", ex);
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
                try
                {
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
                catch (SqlException ex)
                {
                    throw new DaoException("A SQL exception occurred", ex);
                }
            }
            return vocabularies;
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
