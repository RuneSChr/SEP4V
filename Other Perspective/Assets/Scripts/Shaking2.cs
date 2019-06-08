using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class Shaking2 : MonoBehaviour {

    public Hand leftHand,rightHand;
   public float nextShake, vibrationDuration, randomX, randomY, randomZ;



    private void Start()
    {
        nextShake = Time.time + 20;
        StartCoroutine(ShakeTime());
    }
    private void Update()
    {
        vibrationDuration = Random.Range(1, 10);
         randomX = Random.Range(0.1f, 0.3f);
         randomY = Random.Range(0.1f, 0.3f);
         randomZ = Random.Range(0.1f, 0.3f);

    }

    //runs forever as is
    public IEnumerator ShakeTime()
    {
        while (true)
        {
            float currentTime = Time.time;

            if(currentTime > nextShake)
            {
               
                VibrateController(ChooseCurrentHand());
                nextShake = currentTime + Random.Range(1, 40);
                
            }
        }

        yield return null;
    }

    public Hand ChooseCurrentHand()
    {
        if(Random.Range(1,2) == 1)
        {
            return rightHand;
        }else

        return leftHand;
    }

    public void VibrateController(Hand chosentHand)
    {
        //float duration float frequency, float amplitude dont remember how these should be set
        chosentHand.TriggerHapticPulse(vibrationDuration, 50, 5);
    }

    public void MoveHand(Hand chosentHand)
    {
        
        Vector3 originalPosition = chosentHand.transform.position;
        Vector3 newPosition = originalPosition += new Vector3(randomX, randomY, randomZ);
        //there must be a better way...
        chosentHand.transform.position = newPosition;
    }
}
