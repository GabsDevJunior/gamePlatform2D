using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;

    public float speed;
    public float forcejump;

    public Vector2 friction = new Vector2 (1f, 0f);
    void Update()
    {
        jump();
        walk();
    }

    void walk()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector2(speed, rig.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector2(-speed, rig.velocity.y);
        }

        if(rig.velocity.x > 0)
        {
            rig.velocity += friction;
        }

        if (rig.velocity.x < 0)
        {
            rig.velocity -= friction;
        }
    }
    void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rig.velocity = Vector2.up * forcejump;
        }
    }
}
