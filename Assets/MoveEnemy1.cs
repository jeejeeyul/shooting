using UnityEngine;

public class MoveEnemy1 : MonoBehaviour
{
    public float speed = 0.05f;
    public int minFrame = 60;
    public int maxFrame = 120;

    private Vector3 direction;
    private int currentFrame = 0;
    private int maxMoveFrame;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        SetNewDirection();
    }

    void FixedUpdate()
    {
        transform.position += direction * speed;
        currentFrame++;

        // 경계에 닿으면 방향 반전
        if (transform.position.x <= -8f || transform.position.x >= 8f)
        {
            direction *= -1f;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f), transform.position.y, 0);
            currentFrame = 0;
            maxMoveFrame = Random.Range(minFrame, maxFrame + 1); // 방향 바뀔 때마다 새로
        }

        // 지정된 프레임만큼 이동 후 방향 반전
        if (currentFrame >= maxMoveFrame)
        {
            SetNewDirection();
        }
    }

    void SetNewDirection()
    {
        direction = Random.value > 0.5f ? Vector3.left : Vector3.right;
        currentFrame = 0;
        maxMoveFrame = Random.Range(minFrame, maxFrame + 1);
    }
}
