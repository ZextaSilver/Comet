using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public float movement_speed;
    public Rigidbody2D rigid_body;

    float move_x;

    private void Update(){

        move_x = Input.GetAxisRaw("Horizontal");

    }

    public void FixedUpdate(){

        Vector2 movement = new Vector2(move_x * movement_speed, rigid_body.velocity.y);

        rigid_body.velocity = movement;
        
    }
}

