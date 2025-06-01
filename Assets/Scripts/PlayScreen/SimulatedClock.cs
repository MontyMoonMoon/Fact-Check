using UnityEngine;
using TMPro;

public class SimulatedClock : MonoBehaviour
{
    [Header("Assign Both Clock Texts")]
    [SerializeField] private TextMeshProUGUI clockText1;
    [SerializeField] private TextMeshProUGUI clockText2;

    [Header("Clock Settings")]
    [SerializeField] private float secondsPerMinute = 1f;

    private int hour = 9;
    private int minute = 0;
    private float timer;
    private bool isRunning = false;

    void Update()
    {
        if (!isRunning) return;

        timer += Time.deltaTime;

        if (timer >= secondsPerMinute)
        {
            timer = 0f;
            minute++;

            if (minute >= 60)
            {
                minute = 0;
                hour++;
                if (hour >= 24) hour = 0;
            }

            UpdateClockDisplay();

            // Stop at 05:00 (5 AM military time)
            if (hour == 5 && minute == 0)
            {
                isRunning = false;
            }
        }
    }

    void UpdateClockDisplay()
    {
        string timeText = $"{hour:D2}:{minute:D2}";
        if (clockText1 != null) clockText1.text = timeText;
        if (clockText2 != null) clockText2.text = timeText;
    }

    public void StartClock()
    {
        isRunning = true;
    }
}
