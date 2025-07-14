using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; // UI 요소를 사용하기 위해 추가
public class GameManager : MonoBehaviour
{
    public StopWatch StopWatch; // StopWatch 스크립트 참조
    public TextMeshProUGUI timerText; // 타이머 텍스트 UI 참조
    public Image health1;
    public Image health2;
    public Image health3;
    void Start()
    {
    }

    private void SetUpGame()
    {
        SlimeHealth.health = 3; // 슬라임의 초기 체력 설정
        StopWatch.ResetStopwatch(); // 스톱워치 초기화
        health3.enabled = true; // 체력 UI 초기화
        health2.enabled = true; // 체력 UI 초기화  
        health1.enabled = true; // 체력 UI 초기화
        gameOver = false; // 게임 오버 상태 초기화
        GameObject[] targets = GameObject.FindGameObjectsWithTag("bullet");
        foreach (GameObject obj in targets)
        {
            Destroy(obj);
        }
        Time.timeScale = 1; // 게임 시간 재개
        StopWatch.StartStopwatch(); // 스톱워치 시작
    }
    // Update is called once per frame
    private bool gameOver = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetUpGame();
        }

        if (!gameOver && SlimeHealth.health <= 0)
        {
            gameOver = true;
            StopWatch.StopStopwatch();
            Time.timeScale = 0f;
            string result = timerText.text;
            Debug.Log(result);
        }
    }
}