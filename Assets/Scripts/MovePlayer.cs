using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    public Vector2 moveVector;
    public float speed = 1.5f;
    public bool faceRight = true;
    public bool isActive = true;
    public float jumpForce = 7f;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk ();
        Reflect ();
        Jump ();
        CheckingGround ();
    }
    void Walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("MoveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
    }

    void Reflect()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    private void OnTriggerExit2D(Collider2D Ground)
    {
        if (Ground.gameObject.CompareTag("Ground"))
        {
            isActive = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D Ground)
    {
        if (!isActive) return;
        if (Ground.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("onGround", true);
            isActive = false;
        }
    }
}
