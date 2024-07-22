using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public Animator anim;
    public bool ChekAnim = true;
    public bool HeadUp;
    public Transform HeadCheck;
    public float checkRadius = 0.5f;
    public LayerMask Head;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DamageEnemy();
    }
    void DamageEnemy()
    {
        HeadUp = Physics2D.OverlapCircle(HeadCheck.position, checkRadius, Head);
        anim.SetBool("Death", HeadUp);
        ChekAnim = false;
    }  
    void Death()
    {
        if (ChekAnim == false)
        Destroy(gameObject);
    }
}
