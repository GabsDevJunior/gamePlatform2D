using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    public int dano = 3;


    private void OnCollisionEnter2D(Collision2D collision)
{

        var health = collision.gameObject.GetComponent<healthBase>();

        if (health != null)
        {
   
            health.Damage(dano);
        }

}
}
