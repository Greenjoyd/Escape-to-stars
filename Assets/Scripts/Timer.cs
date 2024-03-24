using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float elapsedTime = 0f;
    private Text timerText;
    bool timer = true;

    void Start()
    {
        timerText = GetComponentInChildren<Text>();

    }

    void Update()
    {
        if (timer)
        {
            elapsedTime += Time.deltaTime;

            if (timerText != null)
            {
                timerText.text = FormatTime(elapsedTime);
            }
        }
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
  /*  public void StartTimer()
    {
        timer = true;
    }*/
}
