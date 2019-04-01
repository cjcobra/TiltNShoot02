using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("InGameMenu");

    }

    public void MainMenuInGame()
    {
                Application.LoadLevel("MainMenu");
    }
}
