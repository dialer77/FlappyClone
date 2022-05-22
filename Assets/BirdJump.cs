using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.up * jumpPower;
        }
        
    }
}
