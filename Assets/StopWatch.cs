using UnityEngine;
using TMPro;

public class StopWatch : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float elapsedTime = 0f;
    private bool isRunning = true;

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        int milliseconds = Mathf.FloorToInt((elapsedTime * 100f) % 100f); // 소수점 두 자리

        timerText.text = $"{minutes:00}:{seconds:00}.{milliseconds:00}";
    }

    // 외부에서 제어 가능하도록 함수 추가
    public void StartStopwatch() => isRunning = true;
    public void StopStopwatch() => isRunning = false;
    public void ResetStopwatch()
    {
        isRunning = false;
        elapsedTime = 0f;
        UpdateTimerDisplay();
    }
}
