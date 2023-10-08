using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FullScreen : MonoBehaviour
{
    private bool isFullScreen = false;

    void Start()
    {
        // Ban đầu, bạn có thể kiểm tra xem trò chơi đang chạy ở chế độ toàn màn hình hay không.
        isFullScreen = Screen.fullScreen;
    }

    public void ToggleFullScreen()
    {
        // Đảo ngược trạng thái fullscreen và áp dụng nó.
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    public void Exit()
    {
        Application.Quit();
    }
}