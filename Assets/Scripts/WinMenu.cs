using UnityEngine;
using TMPro;

public class WinMenu : MonoBehaviour
{
    public TMP_Text finalTimeText;

    void Start()
    {
        float finalTime = PlayerPrefs.GetFloat("FinalTime", 0f);
        int minutes = Mathf.FloorToInt(finalTime / 60);
        int seconds = Mathf.FloorToInt(finalTime % 60);
        int milliseconds = Mathf.FloorToInt((finalTime * 1000) % 1000);
        finalTimeText.text = "" + string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}