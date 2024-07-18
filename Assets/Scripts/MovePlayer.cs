using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer sr;
    public Vector2 MoveVector;
    public float speed = 1.5f;
    public bool FaceRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
        Reflect();
    }
    void Walk()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("MoveX", Mathf.Abs(MoveVector.x));
        rb.velocity = new Vector2(MoveVector.x * speed, rb.velocity.y);
    }

    void Reflect()
    {
        if ((MoveVector.x > 0 && !FaceRight) || (MoveVector.x < 0 && FaceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            FaceRight = !FaceRight;
        }
    }
}
