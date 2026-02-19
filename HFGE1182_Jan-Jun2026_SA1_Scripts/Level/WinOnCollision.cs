using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinOnCollision : MonoBehaviour
{
    public string sceneName;
    public void OnTriggerEnter(Collider trig)
    {
        if (trig.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
