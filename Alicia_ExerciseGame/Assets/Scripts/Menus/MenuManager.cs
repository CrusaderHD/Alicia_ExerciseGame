using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;

public class MenuManager : MonoBehaviour
{


    public void PlayGame()
    {
        //Starts the game at LevelOne
        Debug.Log("Starting Game");
        StartCoroutine(StartGameCountdownTimer());

    }

    public void QuitGame()
    {
        //Quit Game from Main Menu
        Debug.Log("Quitting Game from Main Menu.");
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        //Returns player to MainMenu from ingame. 
        Debug.Log("Returning to main menu.");
        SceneManager.LoadScene("_MainMenu", LoadSceneMode.Additive);
    }


    IEnumerator StartGameCountdownTimer()
    {
        yield return new WaitForSeconds(10); 
        SceneManager.LoadScene("Level1");
    }


}
