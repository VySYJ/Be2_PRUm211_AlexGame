using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load_Game : MonoBehaviour
{
    public GameObject startMenuCanvas;
    public GameObject pauseMenuCanvas;

    private bool gameStarted = false;

    private void Start()
    {
        // Ban đầu chỉ hiển thị Start Menu
        startMenuCanvas.SetActive(true);
        pauseMenuCanvas.SetActive(false);
    }

    // Hàm này được gọi khi trò chơi bắt đầu từ màn hình Menu chính
    public void StartGame()
    {
        gameStarted = true;
        startMenuCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(true);
    }

    // Hàm này được gọi khi người chơi nhấn nút "Play" trong menu chính
    public void PlayButtonClicked()
    {
        SceneManager.LoadScene(1); // Thay "TênSceneCủaTròChơi" bằng tên của scene trò chơi của bạn
      
    }
}
