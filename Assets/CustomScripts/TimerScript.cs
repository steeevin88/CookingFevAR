using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float totalTime = 60f;  // Total time for the timer in seconds
    public string item = "";
    private float currentTime;      // Current time remaining
    private bool isRunning = false; // Flag to check if the timer is currently running
    private bool colorInterval = false;

    public TextMeshProUGUI timerText;  // Reference to the Text component for displaying the timer

    void Start()
    {
        ResetTimer();
        isRunning = true;
    }

    void Update()
    {
        if (colorInterval && !isRunning)
        {
            timerText.color = Color.red;
            colorInterval = !colorInterval;
        } else if(!isRunning) { 
            timerText.color = Color.white;
            colorInterval = !colorInterval;
        }
        currentTime -= Time.deltaTime;  // Update the timer based on real-time
        UpdateTimerText();
    }

    // Method to start the timer
    public void StartTimer()
    {
        isRunning = true;
    }

    // Method to add 30 seconds to the timer
    public void Add30Seconds()
    {
        currentTime += 30f;
        UpdateTimerText();  // Update the timer text after adding time
    }

    // Method to reset the timer to the initial total time
    public void ResetTimer()
    {
        currentTime = totalTime;
        isRunning = false;
        UpdateTimerText();  // Update the timer text after resetting
    }

    // Method to update the timer text
    private void UpdateTimerText()
    {
        float currentTimeInSeconds = Mathf.Floor(currentTime);
        if (currentTimeInSeconds % 2 == 0)
        {
            // Set the text color to white if the time is even
            timerText.color = Color.white;
        }
        else if(currentTimeInSeconds < 0)
        {
            // Set the text color to red if the time is odd
            timerText.color = Color.red;
        }
        if(currentTime < 0)
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