using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;

public class Player : MonoBehaviour
{
    public Rigidbody2D rig;

    public float maxSpeed;
    public float minSpeed;
    public float speed;
    public float forcejump;

    public Vector2 friction = new Vector2 (1f, 0f);

    public healthBase health;

    [Header("Animation")]
    public float JumpScaleY = 1.5f;
    public float JumpScaleX = .7f;
    public float GroundAnimationY = 1.5f;
    public float GroundAnimationX = .5f;
    public float AnimationDurationJump;
    public float AnimationDurationGround;
    public Ease ease = Ease.OutBack;

    public bool onJump;
    public bool onDoubleJump;
    void Update()
    {
        if (!health._isDead)
        {
            jump();
            walk();
        }
        
    }

    void walk()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = maxSpeed;
        }
        else
        {
            speed = minSpeed;
        }

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
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (rig.velocity.x < 0)
        {
            rig.velocity -= friction;
            transform.eulerAngles = new Vector2(0, 180);
        }
    }

    void resetAnim()
    {
        rig.transform.localScale = new Vector2(1, 1);

        DOTween.Kill(rig.transform);
    }
    void jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (!onJump)
            {
                rig.velocity = Vector2.up * forcejump;
                onJump = true;
                onDoubleJump = false;
                resetAnim();
                ScaleJump();
            }
            else if(!onDoubleJump)
            {
                rig.velocity = Vector2.up * forcejump;
                    onDoubleJump = true;
                resetAnim();
                ScaleJump();
            }
        }
    }



    void ScaleJump()
    {
        rig.transform.DOScaleY(JumpScaleY, AnimationDurationJump).SetLoops(2, LoopType.Yoyo).SetEase(ease);
        rig.transform.DOScaleX(JumpScaleX, AnimationDurationJump).SetLoops(2, LoopType.Yoyo).SetEase(ease);
    }

    void animGround()
    {
        rig.transform.DOScaleY(GroundAnimationY, AnimationDurationGround).SetLoops(2, LoopType.Yoyo).SetEase(ease);
        rig.transform.DOScaleX(GroundAnimationX, AnimationDurationGround).SetLoops(2, LoopType.Yoyo).SetEase(ease);
        
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 9)
        {
          
            resetAnim();


            animGround();
            onJump = false;
            onDoubleJump = true;
            


            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {  


            
        }
    }
}
