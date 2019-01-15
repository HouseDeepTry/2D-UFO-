using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverManager : MonoBehaviour
{
    public void ChangeLevel(int numberlevel)
    {
        Application.LoadLevel(numberlevel);
    }
    public void QuitLevel()
    {
        Application.Quit();
    }
}
