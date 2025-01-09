using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBase : MonoBehaviour
{

    public projetilBase prefeab;

    public Transform positionToShoot;

    public float TimeShoot;

    public Transform PlayerReference;

    private Coroutine _correntCoroutine;

    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            _correntCoroutine = StartCoroutine(StartShoot());
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            if(_correntCoroutine != null) StopCoroutine(_correntCoroutine);
        }
    }
      IEnumerator StartShoot()
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(TimeShoot);
        }
    }

    // Update is called once per frame
    void Shoot()
    {
        var projectile = Instantiate(prefeab);
        projectile.transform.position = positionToShoot.position;
      
    }
}
