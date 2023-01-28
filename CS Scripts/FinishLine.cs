using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float stopTime = 1f;
    [SerializeField] ParticleSystem finishEffect;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", stopTime);
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
