using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Load_Level : MonoBehaviour
{
    public Button[] buttons;
   // public GameObject levelButtons;
    private void Awake()
    {
        int unlockedLevel1 = PlayerPrefs.GetInt("UnlockedDark", 1);
        unlockedLevel1 = Mathf.Clamp(unlockedLevel1, 0, buttons.Length); // Đảm bảo unlockedLevel1 không vượt quá độ dài của mảng buttons
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < unlockedLevel1; i++)
        {
            buttons[i].interactable = true;
        }
    }
    /*public void OpenLevel(int levelId)
    {
        string levelName = "Dark" + levelId;
        SceneManager.LoadScene(levelName);
    }*/
    public void level1()
    {
        SceneManager.LoadScene(1);
    }
    public void level2()
    {
        SceneManager.LoadScene(2);
    }
    public void level3()
    {
        SceneManager.LoadScene(3);
    }
    public void level4()
    {
        SceneManager.LoadScene(4);
    }
    public void level5()
    {
        SceneManager.LoadScene(5);
    }
    
}
