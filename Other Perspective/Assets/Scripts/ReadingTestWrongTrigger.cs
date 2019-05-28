using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingTestWrongTrigger : MonoBehaviour
{

    public GameObject currentPassage;
    public GameObject nextPassage;
    public GameObject currentdoor;
    public GameObject nextdoor;
    public AudioSource source;
    public AudioClip clip;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            source.PlayOneShot(clip);

            currentPassage.SetActive(false);
            nextPassage.SetActive(true);

            currentdoor.SetActive(false);
            nextdoor.SetActive(true);
        }
    }

}
