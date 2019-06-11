using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetKey : MonoBehaviour
{
    public Transform originalPosition;
    public GameObject key;
    // Use this for initialization
    void Start()
    {
        originalPosition = key.transform;
        
        
    }

    private void OnTriggerExit(Collider other)
    {
        key.transform.position = originalPosition.position;
    }
    
}