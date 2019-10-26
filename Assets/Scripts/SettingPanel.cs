using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingPanel : MonoBehaviour
{
    public GameObject settingPanel; private bool isQuitting;
    

    // Start is called before the first frame update
    void Start()
    {
        if(Time.timeScale == 1)
        {
            settingPanel.SetActive(false);
        }
        else
        {
            settingPanel.SetActive(true);
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
       
        AudioListener.pause = true;
        
        settingPanel.SetActive(true);

    }

    public void RestartGame()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        settingPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void ResumeGame()
    {
        settingPanel.SetActive(false);
        Time.timeScale = 1;
        AudioListener.pause = false;
       
    }

    public void ExitGame()
    {
      SceneManager.LoadScene(0);  
    }
  
}
