using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject backButtonGameObject; // Gán GameObject chứa nút "Continue" trong Inspector

    private bool isFromPauseMenu = false;

    private void Start()
    {
        // Ban đầu, vô hiệu hóa nút "Continue"
        if (backButtonGameObject != null)
        {
            backButtonGameObject.SetActive(true);
        }
    }

    public void EnterSettingsFromPauseMenu()
    {
        // Khi người chơi vào màn hình Settings từ MainMenu
        isFromPauseMenu = false;

        // Ẩn nút "Continue" (nếu đã gán đúng GameObject trong Inspector)
        if (backButtonGameObject != null)
        {
            backButtonGameObject.SetActive(false);
        }
    }

    public void EnterSettingsFromMainMenu()
    {
        // Khi người chơi vào màn hình Settings từ Pause Menu
        isFromPauseMenu = true;

        // Kích hoạt nút "Continue" (nếu đã gán đúng GameObject trong Inspector)
        if (backButtonGameObject != null)
        {
            backButtonGameObject.SetActive(true);
        }
    }

    public void OnPauseButtonClick()
    {
        // Kiểm tra xem người chơi đã vào màn hình Settings từ Pause Menu hay không
        if (isFromPauseMenu)
        {
            backButtonGameObject.SetActive(true); // Kích hoạt nút "Continue"
        }
        // Thực hiện các xử lý khác khi nhấn nút "Pause"
    }
}