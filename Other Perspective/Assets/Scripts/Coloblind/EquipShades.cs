using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipShades : MonoBehaviour {
    
    private ColorBlindHandler Handler;
    [SerializeField]
    private int ShaderIndex;



    // Use this for initialization
    void Start () {
        Handler = GameObject.Find("Colorblind").GetComponent<ColorBlindHandler>();
        print(Handler);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Inside trigger");
        if(other.gameObject.name == "VRCamera")
        {
            print("hey");
            Handler.ChangeSpectrum(ShaderIndex);
            //f
            //gameObject.SetActive(false);
            
        }
        
    }

   

}
