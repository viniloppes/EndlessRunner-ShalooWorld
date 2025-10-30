using System;
using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private ParticleSystem speedUpParticle;
    [SerializeField] private float minFOV = 30.0f;
    [SerializeField] private float maxFOV = 120.0f;

 
    [SerializeField] private float zoomDuration = 1f;
    [SerializeField] private float zoomSpeedModifier = 5.0f;
    

    private CinemachineCamera cinemachineCamera;

    void Start()
    {
        cinemachineCamera = GetComponent<CinemachineCamera>();
    }

    public void ChangeCameraFOV(float speedAmount)
    {
        StopAllCoroutines();
        StartCoroutine(ChangeFOVRoutine(speedAmount));
        if (speedAmount > 0)
        {
            speedUpParticle.Play();
         
        }
    }


    private IEnumerator ChangeFOVRoutine(float amount)
    {
        float startFOV = cinemachineCamera.Lens.FieldOfView;
        float newFOV = startFOV + (amount * zoomSpeedModifier);
        float targetFOV = Math.Clamp(newFOV , minFOV, maxFOV);
        float elapsedTime = 0;
        while (elapsedTime < zoomDuration)
        {
            float t = elapsedTime / zoomDuration;
            elapsedTime += Time.deltaTime;
            cinemachineCamera.Lens.FieldOfView = Mathf.Lerp(startFOV, targetFOV, t);

            yield return null;
        }

        cinemachineCamera.Lens.FieldOfView = targetFOV; //Certifica caso a transição não seja concluida
    }
}