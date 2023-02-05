using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public int force = 100;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal") * Time.fixedDeltaTime;
        float moveVertical = Input.GetAxis("Vertical") * Time.fixedDeltaTime;
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb.AddForce (movement * force);
    }

}