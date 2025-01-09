using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class healthBase : MonoBehaviour
{
    public Rigidbody2D rig;

    public float maxLife = 3;
    public float _currentLife = 3;
    public float DelayToKill;

    public PlayerAnim playerAnim;

    public bool destroyOnKill = false;
    public bool _isDead = false;
   


    void Awake() // Corrigido para maiúscula
    {
        Init();
        if(rig == null ) rig = GetComponent<Rigidbody2D>();
    }

    void Init()
    {
        _isDead = false;
        _currentLife = maxLife; // Garante que a vida atual seja o valor máximo.
    }

    public void Damage(int damage)
    {
        Debug.Log("ola");
        if (_isDead) return;
        _currentLife -= damage;
        playerAnim.dano();

        if (_currentLife <= 0)
        {
            rig.velocity = Vector2.zero;
            rig.angularVelocity = 0f;
            Kill();
        }
    }

    void Kill()
    {
        rig.velocity = Vector2.zero;
        rig.angularVelocity = 0f;
        _isDead = true;
        

        if (destroyOnKill)
        {
            Destroy(gameObject, DelayToKill);
        }
    }


}