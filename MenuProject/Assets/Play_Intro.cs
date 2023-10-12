using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Play_Intro : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string menuSceneName = "MenuStart";

    private bool hasVideoEnded = false;

    void Start()
    {
        // Đăng ký sự kiện khi video kết thúc
        videoPlayer.loopPointReached += OnVideoEnd;

        // Phát video intro
        videoPlayer.Play();
    }

    void OnVideoEnd(UnityEngine.Video.VideoPlayer vp)
    {
        PlayerPrefs.SetInt("MenuState", 0); // Hoặc 1 tùy vào trạng thái mong muốn

        // Khi video kết thúc, chuyển đổi đến scene menu
        SceneManager.LoadScene(menuSceneName);
    }

    

    void OnDestroy()
    {
        // Hủy đăng ký sự kiện khi script bị hủy
        videoPlayer.loopPointReached -= OnVideoEnd;
    }
}