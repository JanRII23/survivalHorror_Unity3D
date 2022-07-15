using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    /*public GameObject selectCharacter; //implement later;*/
    public GameObject mainMenu;

    /*public void OnSelectCharacter()  //the option one right now is set to quit game since i havent implemented it yet
    {
        selectCharacter.SetActive(true);
        mainMenu.SetActive(false);
    }*/

    public void OnPlayButton()
    {
        SceneManager.LoadScene("ZombieLand");
    }

    public void OnQuitButton()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }


}
