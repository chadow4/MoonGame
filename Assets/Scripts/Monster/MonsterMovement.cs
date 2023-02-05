using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] int force = 100;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Random.Range(-0.2f, 0.2f) * Time.fixedDeltaTime;
        float moveVertical = Random.Range(-0.2f, 0.2f) * Time.fixedDeltaTime;
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb.AddForce (movement * force);
    }

}