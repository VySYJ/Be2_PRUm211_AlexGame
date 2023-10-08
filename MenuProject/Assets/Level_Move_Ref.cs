using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Level_Move_Ref  : MonoBehaviour
{
    public int scenceBuildIndex;

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        if (other.tag == "Player")
        {
            print("Switching Scene to " + scenceBuildIndex);
            SceneManager.LoadScene(scenceBuildIndex, LoadSceneMode.Single);

        }
        
    }
}
