using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

namespace scripts.Singleton
{



    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
            }
            else
            {
                Destroy(gameObject);
            }

            
        }
    }

}
