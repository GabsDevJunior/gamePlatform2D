using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using scripts.Singleton;
using DG.Tweening;

public class GameManager : Singleton<GameManager>
{
    [Header("Player")]
    public GameObject player;

    [Header("Enemys")]
    public List<GameObject> Enemys;

    [Header("Referencers")]
    public Transform startPoint;


    [Header("Animation")]
    public float duration = .2f;
    public float delay = 0.5f;
    public Ease ease = Ease.OutBack;

    private GameObject _currentPlayer;

    void Start()
    {
        init();
    }

    public void init()
    {
        spawnPlayer();
    }

    public void spawnPlayer()
    {
        _currentPlayer = Instantiate(player);
        _currentPlayer.transform.position = startPoint.transform.position;
        _currentPlayer.transform.DOScale(0, duration).SetEase(ease).From();
    }
        


}
