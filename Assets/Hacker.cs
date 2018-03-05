using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    const string menuHint = "you can write menu at any time";
    string[] level1Passwords = {"books", "aisle", "shelf", "password", "font", "borrow"};
    string[] level2Passwords = { "gun", "cheif", "law", "badge", "enforcement", "cop" };
    string[] level3Passwords = { "NASA", "imsocool", "engineer", "scientist" };
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

    // Use this for initialization
    void Start () {

        var greeting = "long ass greeting";
        ShowMainMenu();
    }
    int level;

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
      //  Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("Enter your selection: ");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnUserInput(string input)
    {
        if(input == "menu")
        {
            ShowMainMenu();
            currentScreen = Screen.MainMenu;
        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);

        }else if(currentScreen == Screen.Password)
        {
            RunPassword(input);
        }



    }
    void RunPassword(string input)
    {
        if(level == 1)
        {
            password = level1Passwords[Random.Range(0, level1Passwords.Length)];
            Terminal.WriteLine(password.Anagram());
            if(password == input)
            {
                DisplayWinScreen();

            }
            else
            {
                Terminal.WriteLine("try again");
            }

        }else if(level == 2)
        {
            password = level2Passwords[Random.Range(0, level2Passwords.Length)];
            Terminal.WriteLine(password.Anagram());
            if (password == input)
            {
                DisplayWinScreen();
            }
            else
            {
                Terminal.WriteLine("try again");
            }
        }else if(level == 3)
        {
            password = level3Passwords[Random.Range(0, level3Passwords.Length)];
            Terminal.WriteLine(password.Anagram());
            if (password == input)
            {
                DisplayWinScreen();
            }
            else
            {
                Terminal.WriteLine("try again");
            }
        }
    }

    void DisplayWinScreen()
    {

        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("havea book");
                Terminal.WriteLine(@"
///
(___________(
 (___________(
  (___________(
    
***
;;;
");
                break;
            case 2:
                Terminal.WriteLine("you got the prison eky");
                break;
            default:
                Debug.Log("error nivalid level");
                break;
        }
    }

    private void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("please choose a valid onje, dude");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("please enter your password");


    }
}
