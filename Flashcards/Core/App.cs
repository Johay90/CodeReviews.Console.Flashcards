﻿using System.Security.Cryptography.X509Certificates;
using System.Configuration;

public class App
{
    private UserInput _userInput;
    private DatabaseManager _databaseManager;

    public void Run()
    {
        _userInput = new UserInput();
        _databaseManager = new DatabaseManager(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        _databaseManager.InitializeDB();

        var mainMenuOption = _userInput.MainMenu();

        switch (mainMenuOption)
        {
            case MainMenuOptions.Stacks:

                break;
            case MainMenuOptions.Flashcards:
                break;
            case MainMenuOptions.Study:
                break;
            case MainMenuOptions.Exit:
                Environment.Exit(0);
                break;
        }
    }

    public void ManageStacks() // TODO would it be better to have a ManageStacks class?
    {
        var stackList = ""; // controller.GetAllStacks();

        // Place pick a Stack by entering it's name:
        // valiadate: empty, stack exists etc.

    }
}