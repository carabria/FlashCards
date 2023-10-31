﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashCards.DAO;

namespace FlashCards.Classes
{
    public class UserInterface
    {
        private readonly VocabularySqlDao vocabularySqlDao;

        public UserInterface(string connectionString)
        {
            vocabularySqlDao = new VocabularySqlDao(connectionString);

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
                    case "4":
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

        private void BeginApplication()
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

        private void AddVocabulary()
        {
            throw new NotImplementedException();
        }

        private void ViewVocabulary()
        {
            bool isFinished = false;
            while (!isFinished)
            {
                Console.WriteLine("Please make an entry");
                Console.WriteLine("1: View all vocabulary");
                Console.WriteLine("2: View specific vocabulary");
                Console.WriteLine("E: Exit");
                string response = Console.ReadLine().ToUpper();
                switch (response)
                {
                    case "1":
                        ShowAllVocabulary();
                        break;
                    case "2":
                        ShowSpecificVocabulary();
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
            vocabularySqlDao.ListVocabulary();
        }

        private void ShowSpecificVocabulary()
        {
            throw new NotImplementedException();
        }

    }
}
