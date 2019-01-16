using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public GameObject Panel;
    //Scene
    private void Start()
    {
        Panel.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void ChangeLevel(int numberlevel)
    {
        Application.LoadLevel(numberlevel);
    }
    public void QuitLevel()
    {
        Application.Quit();
    }
    public void RestartLevel()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void HidePanel()
    {
        Panel.gameObject.SetActive(false);
    }

    public void AppPanel()
    {
        Panel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
