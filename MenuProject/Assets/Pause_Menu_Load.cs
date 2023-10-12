using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu_Load : MonoBehaviour
{
    private bool isPaused = false;

    public void PauseGame()
    {
        isPaused = true; // Đảm bảo rằng trạng thái là Pause
        PlayerPrefs.SetInt("MenuState", 1); // Lưu trạng thái vào PlayerPrefs
        PlayerPrefs.Save();

        PlayerPrefs.SetInt("CurrentSceneIndex", SceneManager.GetActiveScene().buildIndex);

        SceneManager.LoadScene(0); // Chuyển đến Scene "ABC"
    }
}
