using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLinew : MonoBehaviour
{

    [SerializeField] float resetTimer = 1f; 
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            finishEffect.Play();
            Invoke("ReloadScene", resetTimer);
        }
    }

    void ReloadScene () {
        SceneManager.LoadScene(0);
    }
}
