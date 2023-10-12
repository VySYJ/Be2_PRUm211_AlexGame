using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_Move_Ref  : MonoBehaviour
{
    public GameObject victoryPanel; // Kéo và thả Canvas chứa Panel "Victory" vào đây
    public Button continueButton;   // Kéo và thả Button "Continue" vào đây
    public int sceneIndexToLoad; // Chỉ mục của cảnh bạn muốn chuyển đến
    public int homeSceneName; // Tên của cảnh chính hoặc menu chính
    private bool hasReachedCheckpoint = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasReachedCheckpoint)
        {
            UnclockLevel1();
            Time.timeScale = 0f;
            hasReachedCheckpoint = true;

            victoryPanel.SetActive(true);


            // Dừng thời gian trò chơi (tùy theo thiết kế của bạn)
            //Time.timeScale = 0f;
        }
    }
    void UnclockLevel1()
    {
        if (SceneManager.GetActiveScene().buildIndex >= PlayerPrefs.GetInt("ReachedIndex"))
        {

            PlayerPrefs.SetInt("ReachedIndex", SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("UnlockedDark", PlayerPrefs.GetInt("UnlockedDark", 1) + 1);
            PlayerPrefs.Save();


        }
    }
    public void GoHome()
    {
        // Chuyển đến cảnh chính hoặc menu chính
        SceneManager.LoadScene(homeSceneName);
    }
    public void ContinueButton()
    {
        // Hoặc chuyển đến cảnh khác (tùy thuộc vào thiết kế của bạn)
        SceneManager.LoadScene(sceneIndexToLoad);
        // Vô hiệu hóa Panel Victory và tiếp tục trò chơi
        victoryPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
