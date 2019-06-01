using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingTestWinTrigger : MonoBehaviour
{
    public GameObject[] currentDoorsAndPassage;
    public Animator[] anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            foreach (var VARIABLE in currentDoorsAndPassage)
            {
                VARIABLE.SetActive(false);
            }

            foreach (var VARIABLE in anim)
            {
                VARIABLE.SetBool("startMove",true);
            }
        }
        
    }
}
