using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move_Scen : MonoBehaviour
{
    public string Play_Menu = "ICE";
    // Start is called before the first frame update
   public void Play()
    {
        SceneManager.LoadScene(Play_Menu);
    }

   
   
}
