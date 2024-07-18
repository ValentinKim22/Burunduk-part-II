using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool pickUp;
    public int countGem;
    public Transform PickUpCheck;
    public float checkRadius = 0.5f;
    public LayerMask Gem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PickUpGem();
    }
    void PickUpGem ()
    {
       if (pickUp = Physics2D.OverlapCircle(PickUpCheck.position, checkRadius, Gem))
        {
            countGem++;
            Debug.Log(countGem);
        }

    }
}
