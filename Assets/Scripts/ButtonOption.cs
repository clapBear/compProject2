using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonOption : MonoBehaviour
{
   
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void MainMenu ()
    {
        SceneManager.LoadScene(0);
    }
    // below here are track selections buttons
    public void Track01()
    {
        SceneManager.LoadScene(2);
    }
    public void Track02()
    {
        SceneManager.LoadScene(3);
    }
    public void Track03()
    {
        SceneManager.LoadScene(4);
    }
  
}
