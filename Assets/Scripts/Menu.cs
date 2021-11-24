using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    int sceneNum = 0;

    private void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
    }
    public void StartGame()
    {
        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void AboutAuthor()
    {
        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene(3);
        }
    }

    public void BackToMenu()
    {
        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Exit()
    {
        if (Input.touchCount > 0)
        {
            Application.Quit();
        }
    }

    public void Again()
    {
        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene(sceneNum);
        }
    }

    public void NextLevel()
    {
        if (Input.touchCount > 0)
        {
            if (sceneNum == 1)
            {
                SceneManager.LoadScene(sceneNum + 1);
            }
            if (sceneNum == 2)
            {
                SceneManager.LoadScene(sceneNum - 1);
            }
        }
    }
}
