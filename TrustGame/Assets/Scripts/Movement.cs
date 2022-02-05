using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D PlayerBody;
    
    public float MoveSpeed = 5f;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        PlayerBody.MovePosition(PlayerBody.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
