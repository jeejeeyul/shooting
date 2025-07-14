using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootbullet : MonoBehaviour
{
    public float fq = 0.1f; // 총알 발사 간격 (초 단위)
    public GameObject bulletPrefab; // 총알 프리팹
    void Start()
    {
        StartCoroutine(Shoot()); // Shoot 코루틴 시작
    }
    IEnumerator Shoot()
    {
        while (true)
        {
            // 0~360도 사이의 랜덤 각도 생성
            float randomAngle = Random.Range(0f, 360f);
            Quaternion randomRotation = Quaternion.Euler(0, 0, randomAngle);

            Instantiate(bulletPrefab, transform.position, randomRotation);
            yield return new WaitForSeconds(fq); //0.1초마다 총알 발사
        }
    }
}
