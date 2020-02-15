using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject tutorial;

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }

    public void GoToMenuPage()
    {
        mainMenu.SetActive(true);
        tutorial.SetActive(false);
    }

    public void GoToTutorialPage()
    {
        mainMenu.SetActive(false);
        tutorial.SetActive(true);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }
}
