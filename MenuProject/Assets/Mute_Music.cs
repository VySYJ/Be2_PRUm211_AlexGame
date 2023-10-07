using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute_Music : MonoBehaviour
{
    public Toggle toggleMusic;
    public AudioSource backgroundMusic;

    void Start()
    {
        // Gắn sự kiện OnValueChanged của Toggle để xử lý khi người chơi bật/tắt nhạc nền
        toggleMusic.onValueChanged.AddListener(OnToggleMusic);
    }

    void OnToggleMusic(bool isOn)
    {
        // Bật hoặc tắt nhạc nền dựa trên trạng thái của Toggle
        if (isOn)
        {
            backgroundMusic.Play();
        }
        else
        {
            backgroundMusic.Stop();
        }
    }
}