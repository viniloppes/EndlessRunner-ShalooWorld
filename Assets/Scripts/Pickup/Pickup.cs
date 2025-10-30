using System;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100.0f;
    string playerTag = "Player";

    private void Update()
    {
        transform.Rotate(0,rotationSpeed * Time.deltaTime, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            OnPickup();
        }
    }

 
    protected abstract void OnPickup();
}
