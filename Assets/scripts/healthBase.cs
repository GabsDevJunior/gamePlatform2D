using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class healthBase : MonoBehaviour
{
    public float maxLife = 3;
    public float _currentLife = 3;
    public float DelayToKill;

    public bool destroyOnKill = false;
    public bool _isDead = false;


    void Awake() // Corrigido para maiúscula
    {
        Init();
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
}