using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Animator anim;
    public Rigidbody2D rig;
    public string BoolDeath = "death";

    private void Start()
    {
        if(anim == null) anim = GetComponent<Animator>();
        if(rig == null) rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        animando();
    }

    public void noDano()
    {
        anim.SetBool("dano", false);
    }

    public void dano()
    {
        anim.SetBool("dano", true);
    }




    void animando()
    {
        if (rig.velocity.x == 0)
        {
           anim.SetBool("walk", false);

        }
        else
        {
            anim.SetBool("walk", true);
        }

        
    }
}
