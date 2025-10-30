using System;
using Unity.Cinemachine;
using UnityEngine;

public class Rock : MonoBehaviour
{
    [SerializeField] private ParticleSystem collisionParticles;
    [SerializeField] private AudioSource bounderSmashAudio;
    [SerializeField] private float shakeModifier = 2;
    [SerializeField] private float rockSmashCooldown = 0.5f;
    CinemachineImpulseSource impulseSource;

    private float rockSmashTimer = 0;

    void Awake()
    {
        impulseSource = GetComponent<CinemachineImpulseSource>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (rockSmashTimer > 0) return;
        
        rockSmashTimer = rockSmashCooldown;
        GenerateImpulse();
        HandleCollision(other);
    }

    private void Update()
    {
        if (rockSmashTimer > 0)
        {
            rockSmashTimer -= Time.deltaTime;
        }
    }

    private void GenerateImpulse()
    {
        float distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        float shakeIntensity = (1f / distance) * shakeModifier;
        shakeIntensity = Math.Min(shakeIntensity, 1f);
        impulseSource?.GenerateImpulse(shakeIntensity);
    }

    void HandleCollision(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Vector3 contactPoint = contact.point;
        collisionParticles.transform.position = contactPoint;
        collisionParticles.Play();
        bounderSmashAudio.Play();
    }
}