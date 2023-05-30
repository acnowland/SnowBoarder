using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    CircleCollider2D playerHead; 
    [SerializeField] float resetTimer = .2f; 
    [SerializeField] ParticleSystem playerCrashParticles; 
    private void Start() {
        playerHead = GetComponent<CircleCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground" && playerHead.IsTouching(other.collider)){
            playerCrashParticles.Play();
           Invoke("ReloadScene", resetTimer);
        }
    }

    void ReloadScene () {
        SceneManager.LoadScene(0);
    }
}
