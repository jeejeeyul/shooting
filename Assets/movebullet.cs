using UnityEngine;

public class movebullet : MonoBehaviour
{
    public float moveSpeed = 3f;        // 총알의 이동 속도
    public float spiralTightness = 1f;  // 나선 조임 정도

    private Vector3 center;
    private float angle = 0f;
    private Quaternion initialRotation;

    void Start()
    {
        center = transform.position;
        initialRotation = transform.rotation; // 회전값 저장
    }

    void Update()
    {
        float distanceThisFrame = moveSpeed * Time.deltaTime;
        angle += distanceThisFrame / spiralTightness;

        float radius = spiralTightness * angle;

        // 기본 나선 좌표 (x, y) 생성
        Vector3 localOffset = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius;

        // 초기 회전을 반영하여 방향 적용
        Vector3 worldOffset = initialRotation * localOffset;

        transform.position = center + worldOffset;

        if (Vector3.Distance(transform.position, center) > 20f)
        {
            Destroy(gameObject);
        }
    }
}
