using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;

    public Vector2 velocity;
    
    public float speed;
void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rig.velocity = new Vector2(speed, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rig.velocity = new Vector2(-speed, 0);
        }
    }
}
