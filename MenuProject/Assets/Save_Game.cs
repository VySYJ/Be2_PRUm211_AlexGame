using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save_Game : MonoBehaviour
{
    public void Save()
    {
        // Tìm đối tượng "Player" trong scene
        GameObject playerObject = GameObject.Find("Alex");
        GameObject.FindGameObjectWithTag("Save_Game");
        if (playerObject != null)
        {
            // Lấy vị trí của người chơi
            Vector3 playerPosition = playerObject.transform.position;

            // Lưu vị trí của người chơi
            PlayerPrefs.SetFloat("PlayerPosX", playerPosition.x);
            PlayerPrefs.SetFloat("PlayerPosY", playerPosition.y);
            PlayerPrefs.SetFloat("PlayerPosZ", playerPosition.z);
            PlayerPrefs.Save();

            Debug.Log("Player position saved: X = " + playerPosition.x + ", Y = " + playerPosition.y + ", Z = " + playerPosition.z);
        }
        else
        {
            Debug.LogError("Player object not found in the scene.");
        }
    }
}
