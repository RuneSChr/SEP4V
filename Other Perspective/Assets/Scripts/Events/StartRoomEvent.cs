using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartRoomEvent : MonoBehaviour
{

    //public static UnityEvent startEvent;
    public List<GameObject> stuffToSpawn;
    
    // Use this for initialization
    void Start()
    {
        stuffToSpawn = new List<GameObject>();
        if(IntroductionEvent.introductionStart == null)
        {
            IntroductionEvent.introductionStart = new UnityEvent();
        }
        IntroductionEvent.introductionStart.AddListener(SpawnThings);


    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnThings()
    {
        foreach (GameObject roomThing in stuffToSpawn)
        {
            roomThing.SetActive(true);
        }
    }
}

//spawn things, play first audio, start the timer coroutine, give player vision again