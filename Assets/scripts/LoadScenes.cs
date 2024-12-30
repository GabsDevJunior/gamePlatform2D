using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScenes : MonoBehaviour
{
    public void load(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void load(string s)
    {
        SceneManager.LoadScene(s);
    }
}
