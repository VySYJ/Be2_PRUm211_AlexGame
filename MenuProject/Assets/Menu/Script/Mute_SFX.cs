using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute_SFX : MonoBehaviour
{
    public Toggle sfxToggle;

    private void Start()
    {
        // Kiểm tra trạng thái âm thanh SFX đã được lưu trước đó.
        if (PlayerPrefs.HasKey("SFXMuted"))
        {
            bool isSFXMuted = PlayerPrefs.GetInt("SFXMuted") == 1;
            sfxToggle.isOn = isSFXMuted;
        }

        // Đặt sự kiện cho Toggle để chuyển đổi trạng thái âm thanh SFX.
        sfxToggle.onValueChanged.AddListener(ToggleSFX);
    }

    private void ToggleSFX(bool isMuted)
    {
        // Lưu trạng thái âm thanh SFX mới vào PlayerPrefs.
        PlayerPrefs.SetInt("SFXMuted", isMuted ? 1 : 0);
        PlayerPrefs.Save();
    }

    // Các hàm và sự kiện khác của scene "MenuSetting."
}