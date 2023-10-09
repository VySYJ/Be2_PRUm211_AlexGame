using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup_Exit : MonoBehaviour
{
    [SerializeField] GameObject PopupExit;
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Open()
    {
        PopupExit.SetActive(true);

    }
    public void Close()
    {
        PopupExit.SetActive(false);

    }

}
