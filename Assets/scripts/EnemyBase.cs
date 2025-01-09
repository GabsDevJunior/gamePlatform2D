using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public projetilBase projetil;
    public int dano = 3;
    public Animator anim;
    public string TriggerAttack = "Attack";

    public float maxLife = 3;
    public float _currentLife = 3;
    public float DelayToKill;

    public bool destroyOnKill = true;
    public bool _isDead = false;

    public float layerProjetil = 7;




    void playAttackAnimation()
    {
        anim.SetTrigger(TriggerAttack);


    }

    private void OnCollisionEnter2D(Collision2D collision)
{

        var health = collision.gameObject.GetComponent<healthBase>();

        if (health != null)
        {
            
            health.Damage(dano);
            playAttackAnimation();
        }


}

    public void Damage(int damage)
    {
        
        if (_isDead) return;
        _currentLife -= damage;
     

        if (_currentLife <= 0)
        {

            Kill();
        }
    }

    void Kill()
    {
        
        _isDead = true;


        if (destroyOnKill)
        {
            Destroy(gameObject, DelayToKill);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == layerProjetil)
        {
            var projectile = Instantiate(projetil);
            Damage(projectile.dano);

        }
    }
}
