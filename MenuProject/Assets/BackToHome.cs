using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToHome : MonoBehaviour
{
    public string menuSceneName = "MenuStart"; // Tên của scene menu start

    // Hàm được gọi khi bạn muốn quay lại menu start
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

}