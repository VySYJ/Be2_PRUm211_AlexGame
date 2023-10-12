using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swith_PauseMenu : MonoBehaviour
{
    public GameObject menuStartCanvas; // Kéo và thả Canvas của MenuStart vào đây trong Inspector
    public GameObject pauseMenuCanvas; // Kéo và thả Canvas của PauseMenu vào đây trong Inspector

           void Start()
          {

        int previousMenuState = PlayerPrefs.GetInt("MenuState", 0);
        Debug.Log(previousMenuState);//1

        // Kiểm tra giá trị MenuState từ PlayerPrefs
      if (previousMenuState == 0)
        {
            // Đảm bảo rằng trạng thái ban đầu là MenuStart
            menuStartCanvas.SetActive(true);
            pauseMenuCanvas.SetActive(false);
        }
        else if (previousMenuState == 1)
        {
            Debug.Log("tat ne me!");
            // Trạng thái là Pause, hiển thị PauseMenu
            menuStartCanvas.SetActive(false);
            pauseMenuCanvas.SetActive(true);
        }

        // Xóa giá trị MenuState sau khi đã sử dụng
        PlayerPrefs.DeleteKey("MenuState");
    }

}
