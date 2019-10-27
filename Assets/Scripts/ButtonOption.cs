using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonOption : MonoBehaviour
{

    public void PlayGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
    public void MainMenu ()
    {
      Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    // below here are track selections buttons
    public void Track01()
    {
      Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void Track02()
    {
      Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void Track03()
    {
      Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
