using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("Level");
    }

    public void End()
    {
        Application.Quit();
    }
}
