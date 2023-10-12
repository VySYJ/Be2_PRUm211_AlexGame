using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back_Enable : MonoBehaviour
{
    public GameObject continueButtonGameObject; // Gán GameObject chứa nút "Continue" trong Inspector

    private bool isFromPauseMenu = false;

    private void Start()
    {
        // Ban đầu, vô hiệu hóa nút "Continue"
        if (continueButtonGameObject != null)
        {
            continueButtonGameObject.SetActive(false);
        }
    }

    public void EnterSettingsFromMainMenu()
    {
        // Khi người chơi vào màn hình Settings từ MainMenu
        isFromPauseMenu = false;

        // Ẩn nút "Continue" (nếu đã gán đúng GameObject trong Inspector)
        if (continueButtonGameObject != null)
        {
            continueButtonGameObject.SetActive(false);
        }
    }

    public void EnterSettingsFromPauseMenu()
    {
        // Khi người chơi vào màn hình Settings từ Pause Menu
        isFromPauseMenu = true;

        // Kích hoạt nút "Continue" (nếu đã gán đúng GameObject trong Inspector)
        if (continueButtonGameObject != null)
        {
            continueButtonGameObject.SetActive(true);
        }
    }

    public void OnPauseButtonClick()
    {
        // Kiểm tra xem người chơi đã vào màn hình Settings từ Pause Menu hay không
        if (isFromPauseMenu)
        {
            continueButtonGameObject.SetActive(true); // Kích hoạt nút "Continue"
        }
        // Thực hiện các xử lý khác khi nhấn nút "Pause"
    }
}