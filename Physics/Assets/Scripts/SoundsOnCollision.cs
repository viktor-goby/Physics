using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsOnCollision : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void OnCollisionEnter(Collision collision)
    {
        _audioSource.volume = collision.impulse.magnitude;
        _audioSource.Play();
    }


}
