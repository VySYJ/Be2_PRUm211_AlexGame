using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScenePauseMenu : MonoBehaviour
{
    public GameObject startMenuCanvas; // Kéo và thả Canvas của Start Menu vào đây trong Inspector
    public GameObject pauseMenuCanvas; // Kéo và thả Canvas của Pause Menu vào đây trong Inspector

    public void ShowPauseMenu()
    {
        startMenuCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(true);
    }


}
