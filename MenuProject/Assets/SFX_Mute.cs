using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SFX_Mute : MonoBehaviour
{
    public Toggle sfxToggle;

    public void ToggleSFX()
    {
        // Lưu trạng thái SFX vào PlayerPrefs
        int sfxValue = sfxToggle.isOn ? 1 : 0;
        PlayerPrefs.SetInt("SFXOn", sfxValue);
        PlayerPrefs.Save();
    }
}
