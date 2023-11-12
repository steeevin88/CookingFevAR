using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalTime = 60f;
    public string item = "";
    private float currentTime;
    private bool isRunning = false; 

    public TextMeshProUGUI timerText;

    void Start()
    {
        ResetTimer();
        isRunning = true;
    }

    public void StartStopTimer()
    {
        isRunning = !isRunning;
        //Add30Seconds();
    }

    void Update()
    {
        if(isRunning)
        {
            currentTime -= Time.deltaTime;
            TimerTextUpdate();
        }
    }

    public void Add30Seconds()
    {
        currentTime += 30f;
        TimerTextUpdate();
    }

    public void ResetTimer()
    {
        currentTime = totalTime;
        isRunning = false;
        TimerTextUpdate();
    }

    private void TimerTextUpdate()
    {

        float currentTimeInSeconds = Mathf.Floor(currentTime);
        if(currentTimeInSeconds % 2 == 0 && currentTime < 0)
        {
            timerText.color = Color.red;
        }
        else
        {
            timerText.color = Color.white;
        }

        if (currentTime < 0)
        {
            timerText.text = "00:00 - " + item;
        }
        else
        {
            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);
            string formattedTime = string.Format("{0:00}:{1:00}", minutes, seconds);
            timerText.text = "" + formattedTime + " - " + item;
        }

    }
}