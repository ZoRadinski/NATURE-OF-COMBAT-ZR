using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
   
    public void Pause()
    {

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;

    }

    public void Resume()
    {

        pauseMenu.SetActive(false);

        Time.timeScale = 1f;

    }


    public void ChangeScene(string sceneName)
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(sceneName);

    }


    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("quit");

    }

}
