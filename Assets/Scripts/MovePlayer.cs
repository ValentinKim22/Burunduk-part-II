using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 MoveVector;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }
    void Walk()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(MoveVector.x * speed, rb.velocity.y);
    }
}
