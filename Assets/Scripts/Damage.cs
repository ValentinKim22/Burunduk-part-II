using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public Animator anim;
    public bool ChekAnim = true;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D head)
    {
        if (head.gameObject.name == "GroundCheck")
        {
            anim.SetBool("Death", true);
            gameObject.GetComponent<Collider2D>().enabled = false;
            ChekAnim = false;
        }
    }
    void Death()
    {
        
        if (ChekAnim == false)  
        Destroy(gameObject);
    }
}
