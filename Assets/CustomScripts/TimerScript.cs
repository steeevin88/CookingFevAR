using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float totalTime; // Set the total time for the timer in seconds
    private float currentTime;
    public Text timerText;

    public TimerScript(float startingTime){
        this.totalTime = startingTime;
    }

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            // Update your timer UI or perform actions based on time here
            UpdateTimerUI();

        }
        else
        {
            // Timer has reached zero, perform actions when the timer is complete
            Debug.Log("Timer complete!");
        }
    }

    void UpdateTimerUI()
    {
        // Display the remaining time in the UI
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.Round(currentTime);
        }
    }
}
