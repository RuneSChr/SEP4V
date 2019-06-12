using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IntroductionEvent : MonoBehaviour
{

    public static UnityEvent introductionStart;
    public List<GameObject> stuffToDespawn;
    //public List<GameObject> stuffToSpawn;
    public static bool introOver = false;

    // Use this for initialization
    void Start()
    {
        stuffToDespawn = new List<GameObject>();
        //stuffToSpawn = new List<GameObject>();

        if (introductionStart == null)
        {
            introductionStart = new UnityEvent();
        }

        introductionStart.AddListener(DespawnThings);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void DespawnThings()
    {
        foreach (GameObject roomThing in stuffToDespawn)
        {
            roomThing.SetActive(true);
        }
        
    }
   
}

//we need to despawn introduction items, release the gas and blackout players vision.