namespace FlashCards.Classes
{
    public class Application
    {
        private readonly UserInterface ui;
        public Application()
        {
            ui = new UserInterface();
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the flash card application. Good luck with your studies!");
            Console.WriteLine();
            bool finished = false;
            while (!finished)
            {
                ui.DisplayMainMenu();
                int menuSelection = ui.PromptForInteger("Please choose an option:", 0);
                switch (menuSelection)
                {
                    case 0:
                        break;
                    case 1:
                        BeginApplication();
                        break;
                    case 2:
                        EditSettings();
                        break;
                    case 3:
                        EditVocabulary();
                        break;
                    case 4:
                        ViewVocabulary();
                        break;
                    default:
                        Console.WriteLine("Please make a valid entry");
                        break;
                }
            }
        }

        private void BeginApplication()
        {
            throw new NotImplementedException();
        }

        private void EditSettings()
        {
            throw new NotImplementedException();
        }

        private void EditVocabulary()
        {
            bool finished = false;
            ui.DisplayEditMenu();
            while (!finished)
            {
                int menuSelection = ui.PromptForInteger("Please choose an option:", 0);
                switch (menuSelection)
                {
                    case 0:
                        finished = true;
                        break;
                    case 1:
                        ui.AddVocabulary();
                        break;
                    case 2:
                        ui.EditVocabulary();
                        break;
                    case 3:
                        ui.DeleteVocabularyById();
                        break;
                    case 4:
                        ui.DeleteVocabularyByCategory();
                        break;
                    default:
                        Console.WriteLine("Please make a valid entry");
                        break;
                }
            }
        }

        private void ViewVocabulary()
        {
            bool finished = false;
            while (!finished)
            {
                ui.DisplayViewMenu();
                int menuSelection = ui.PromptForInteger("Please choose an option:", 0);
                switch (menuSelection)
                {
                    case 0:
                        finished = true;
                        break;
                    case 1:
                        ui.ViewAllVocabulary();
                        break;
                    case 2:
                        ui.ViewVocabularyCategories();
                        break;
                    case 3:
                        ui.ViewVocabularyById();
                        break;
                    case 4:
                        ui.ViewVocabularyByName();
                        break;
                    default:
                        Console.WriteLine("Please make a valid entry");
                        break;
                }
            }
        }
    }
}