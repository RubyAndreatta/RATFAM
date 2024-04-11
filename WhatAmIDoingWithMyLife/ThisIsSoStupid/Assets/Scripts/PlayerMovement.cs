using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    public bool PMovement = true;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


    }

    private void FixedUpdate()
    {
        if (PMovement)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        
    }


    public void PlayerMovementBoolCheckFALSE(Rigidbody2D rb)
    {
        PMovement = false;
    }
    public void PlayerMovementBoolCheckTRUE(Rigidbody2D rb)
    {
        PMovement = true;
    }
}
