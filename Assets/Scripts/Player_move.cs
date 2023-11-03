using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    private Rigidbody rb;
    float n = 0;
    float b = 0;
    float m = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float x=Input.GetAxisRaw("Horizontal");
        float y=Input.GetAxisRaw("Vertical");
        // float z=Input.GetAxisRaw("z");
        float z = 0;
        transform.localScale = new Vector3(b, n, m);
        if (z == 0)
        {
            n++;
            b++;
            m++;
        }
        if (x!=0 || y!=0 || z != 0)
        {
            rb.AddForce (new Vector3(x,0,y),ForceMode.Impulse);
            
        }
    }
}
