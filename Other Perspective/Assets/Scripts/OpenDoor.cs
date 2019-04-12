using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{

    private InputField input;
    public GameObject door;
    public GameObject inputField;
    private bool openDoor = false;

    // Use this for initialization
    void Start()
    {
        input = gameObject.GetComponent<InputField>();
//      inputField = gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {  
        if (input.text == "12321")
        {
            door.transform.localPosition -= new Vector3(-4,0, 0);
            inputField.SetActive(false);
                   
        }
    }

    

   
}
