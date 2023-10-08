using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupExit : MonoBehaviour
{
    [SerializeField] GameObject quitPanel;
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OpenPopup()
    {
        quitPanel.SetActive(true);
    }
    public void CLosePopup()
    {
        quitPanel.SetActive(false);
    }
}