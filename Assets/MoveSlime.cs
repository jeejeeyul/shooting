using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSlime : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4, 0); // Initialize position
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -9.0f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 5.0f)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -5.0f)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
    }
}
