using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ✅ 추가 필수

public class Chungdol : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TakeDamage(1);
            Destroy(gameObject); // 충돌 시 Chungdol 오브젝트 제거
        }
    }

    public void TakeDamage(int damage)
    {
        SlimeHealth.health -= damage;

    }
}
