using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed = 2;
    private Transform cachedTransform;
    // // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cachedTransform = transform;
    }

    // Update is called once per frame
    // void Update()
    // {
    //     rb.AddForce(100f * Time.deltaTime, 0);
    // }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveSpeed, 0));
        transform.position = new Vector2(
            Mathf.Clamp(transform.position.x, -6f, 18f),
            Mathf.Clamp(transform.position.y, -7f, 0f)
        );
        if (cachedTransform.position.x >= 18) {
            rb.velocity = Vector2.zero;
        }
    }
}
