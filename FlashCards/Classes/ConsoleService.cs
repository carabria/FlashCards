namespace FlashCards.Classes
{
    public class ConsoleService
    {
        /// <summary>
        /// Prints an error message to the screen, in red text.
        /// </summary>
        /// <param name="message">Message to print.</param>
        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Prints a success message to the screen, in green text.
        /// </summary>
        /// <param name="message">Message to print.</param>

        internal void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        /// <summary>
        /// Waits for the user to press a key before continuing. Used 
        /// after displaying some results, so the user can read the results, 
        /// then press a key to dismiss.
        /// </summary>
        /// <param name="message">Message to display. If NULL, 'Press any key to continue' will be shown.</param>
        public void Pause(string message = null)
        {
            if (message == null)
            {
                message = "Press any key to continue:";
            }
            Console.Write(message);
            Console.ReadKey();
        }

        /// <summary>
        /// Display a prompt and read a string from the keyboard.
        /// </summary>
        /// <param name="message">Prompt to display to the user.</param>
        /// <param name="defaultValue">Optional. Value to be used if the user presses Enter without entering anything.</param>
        /// <returns>String entered by the user.</returns>
        public string PromptForString(string message, string defaultValue = null)
        {
            string defaultPrompt = defaultValue == null ? ": " : $"[{defaultValue}]: ";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{message}{defaultPrompt}");
            Console.ResetColor();
            string input = Console.ReadLine();
            // Did the user take the default value?
            if (input.Length == 0 && defaultValue != null)
            {
                return defaultValue;
            }
            return input;
        }

        /// <summary>
        /// Display a prompt and read an integer from the keyboard. Validates integer is in a range.
        /// </summary>
        /// <param name="message">Prompt to display to the user.</param>
        /// <param name="defaultValue">Optional. Value to be used if the user presses Enter without entering anything.</param>
        /// <returns>Integer entered by the user.</returns>
        public int PromptForInteger(string message, int? defaultValue = null)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ResetColor();
            string input = Console.ReadLine();

            // Did the user take the default value?
            if (input.Trim().Length == 0 && defaultValue.HasValue)
            {
                return defaultValue.Value;
            }
            return Convert.ToInt32(input);
        }
    }
}
