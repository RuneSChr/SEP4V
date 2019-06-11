using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chackpoint : MonoBehaviour {

    public GameObject nextCheckpoint;
    private static int countCheckpoints;

    void Start()
    {
        countCheckpoints = 0;
        KeyCollide.collided += DisableCkeckpoint;
    }
    private void OnTriggerEnter(Collider other)
    {
        countCheckpoints++;
        if (countCheckpoints < 3)
            nextCheckpoint.SetActive(true);
        else
            nextCheckpoint.SetActive(false);

    }
    public void DisableCkeckpoint()
    {
        countCheckpoints = 0;
        if(nextCheckpoint != null) nextCheckpoint.SetActive(false);
        
    }
}
