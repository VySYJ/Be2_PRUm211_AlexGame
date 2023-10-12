using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart5 : MonoBehaviour
{
    public void RestartCurrentMap()
    {

        // Lấy index của scene hiện tại

        int currentSceneIndex = PlayerPrefs.GetInt("CurrentSceneIndex");


        if (currentSceneIndex == 1)
        {
            SceneManager.LoadScene(1);
        }
        else if (currentSceneIndex == 2)
        {
            SceneManager.LoadScene(2);
        }
        else if (currentSceneIndex == 3)
        {
            SceneManager.LoadScene(3);
        }
        else if (currentSceneIndex == 4)
        {
            SceneManager.LoadScene(4);
        }
        else if (currentSceneIndex == 5)
        {
            SceneManager.LoadScene(5);
        }

        else
        {
            SceneManager.LoadScene(0); // Đây là index của scene mặc định
        }
    }
}
