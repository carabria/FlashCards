using FlashCards.Classes;
using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your connection string.");
            string connectionString = Console.ReadLine();
            UserInterface UI = new UserInterface(connectionString);
            UI.Run();

        }
    }
}
