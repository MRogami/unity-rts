using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    /*
     * MAIN MENU CONTROLLER
     */
    // 'Play'-Button. Change Scene to Game.
	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // 'Quit'-Button. Exit application.
    public void QuitGame()
    {
        Debug.Log("Attempting to quit application.");
        Application.Quit();
    }
}
