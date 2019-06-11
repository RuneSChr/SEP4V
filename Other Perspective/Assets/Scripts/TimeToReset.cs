using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeToReset : MonoBehaviour
{
    private int time;
    public AudioSource audioSrc;
    public AudioClip start, fiveMinutes, tenMinutes, fifteenMinutes;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Timer()
    {
        audioSrc.PlayOneShot(start);
        while (true)
        {
            if (time >= 300)
            {
                audioSrc.PlayOneShot(fiveMinutes);
            }
            if (time >= 600)
            {
                audioSrc.PlayOneShot(tenMinutes);
            }
            if (time >= 900)
            {
                //reset game perhaps spawn gas
                audioSrc.PlayOneShot(fifteenMinutes);
                StopAllCoroutines();

            }
            yield return new WaitForSeconds(1f);
            time++;
        }
    }
}