using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moving : MonoBehaviour
{


    public string menuSceneName = "save"; // Tên của scene menu start

    // Hàm được gọi khi bạn muốn quay lại menu start
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

}
