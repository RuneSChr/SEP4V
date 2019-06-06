using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipShades : MonoBehaviour {
    
    private ColorBlindHandler Handler;
    [SerializeField]
    private int ShaderIndex;



    // Use this for initialization
    void Start () {
        Handler = GameObject.Find("Sunglasses").GetComponent<ColorBlindHandler>();
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "VRCamera")
        {
            
            Handler.ChangeSpectrum(ShaderIndex);
            //f
            gameObject.SetActive(true);
            
        }
        
    }

   

}
