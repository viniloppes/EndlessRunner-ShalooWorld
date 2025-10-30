using System;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      Destroy(other.transform.gameObject);
   }
}
