using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public bool HeadUp;
    public Transform HeadCheck;
    public float checkRadius = 0.3f;
    public LayerMask Head;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DamageEnemy();
    }
    void DamageEnemy()
    {
        HeadUp = Physics2D.OverlapCircle(HeadCheck.position, checkRadius, Head);
        if (HeadUp == true )
        {
            Destroy(gameObject);
        }
        
    }
}
