using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem slideParticle;
    // Update is called once per frame

    void OnCollisionEnter2D(Collision2D other) {
        slideParticle.Play();
    }
    void OnCollisionExit2D(Collision2D other) {
        slideParticle.Stop();
    }
}
