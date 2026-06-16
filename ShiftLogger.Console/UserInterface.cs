using Spectre.Console;
namespace ShiftLogger.Console;

internal class UserInterface
{
    internal void MainMenu()
    {
        bool isCloseApp = false;
        while (!isCloseApp)
        {
            AnsiConsole.Clear();
            AnsiConsole.MarkupLine("[bold yellow]---Welcome to Shifts Logger---[/]\n");

            var choice = AnsiConsole.Prompt(new SelectionPrompt<Enums.MenuOptions>()
                                            .Title("What would you like to do?")
                                            .AddChoices(Enum.GetValues<Enums.MenuOptions>()));

            switch (choice) 
            {
                case Enums.MenuOptions.ViewShifts:
                    ViewShifts();
                    break;
                case Enums.MenuOptions.AddShift:
                    AddShifts();
                    break;
                case Enums.MenuOptions.UpdateShift:
                    UpdateShifts();
                    break;
                case Enums.MenuOptions.DeleteShift:
                    DeleteShifts();
                    break;
                case Enums.MenuOptions.CloseApp:
                    isCloseApp = true;
                    break;
            }
        }

    }

    private void ViewShifts()
    {
        throw new NotImplementedException();
    }

    private void AddShifts()
    {
        throw new NotImplementedException();
    }

    private void UpdateShifts()
    {
        throw new NotImplementedException();
    }

    private void DeleteShifts()
    {
        throw new NotImplementedException();
    }

}
