using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadingTestWinTrigger : MonoBehaviour
{
    public GameObject[] currentDoorsAndPassage;
    public Animator[] anim;
    public GameObject laserRule;

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
           SceneManager.LoadScene("Go between Laser Puzzle");
        }
        
    }
}
