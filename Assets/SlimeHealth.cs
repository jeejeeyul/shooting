using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI 요소를 사용하기 위해 추가

public class SlimeHealth : MonoBehaviour
{
    public static int health = 3; // 슬라임의 초기 체력

    public Image health1;
    public Image health2;
    public Image health3;

    void Update()
    {
        switch (health)
        {
            case 2:
                health3.enabled = false; // 체력이 2일 때 health3 비활성화
                break;
            case 1:
                health2.enabled = false; // 체력이 1일 때 health2 비활성화
                break;
            case 0:
                health1.enabled = false; // 체력이 0일 때 health1 비활성화
                break;
        }
    }
}
