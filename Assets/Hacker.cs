using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string l1pw = "dog";
    string l2pw = "cat";

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
            if(l1pw == input)
            {
                Terminal.WriteLine("yes");
            }
            else
            {
                Terminal.WriteLine("try again");
            }

        }else if(level == 2)
        {

            if(l2pw == input)
            {
                Terminal.WriteLine("YES");
            }
            else
            {
                Terminal.WriteLine("try again");
            }
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "2")
        {
            level = 2;
            StartGame();
        }
        else if (input == "1")
        {

            level = 1;
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
        Terminal.WriteLine("you have chosen " + level);
        Terminal.WriteLine("please enter your password");
    }
}
