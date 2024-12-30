using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonsManagers : MonoBehaviour
{
    public List<GameObject> buttons;

    [Header("Animation")]
    public float duration = .2f;
    public float delay = 0.5f;
    public Ease ease = Ease.OutBack;


    private void OnEnable()
    {
        ShowButtons();
        MideAllButtons();
    }

    void MideAllButtons()
    {
        foreach (var b in buttons)
        {
            b.transform.localScale = Vector3.zero;

        }
    }

    void ShowButtons()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            var b = buttons[i];
            b.SetActive(true);
            b.transform.DOScale(1, duration).SetDelay(1 * duration).SetEase(ease);
        }
    }

  
      
    
}
