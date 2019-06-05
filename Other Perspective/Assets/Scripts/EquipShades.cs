using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipShades : MonoBehaviour {
    
    private ColorBlindHandler Handler;
    [SerializeField]
    private readonly int ShaderIndex;



    // Use this for initialization
    void Start () {
        Handler = GameObject.Find("GameManager").GetComponent<ColorBlindHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Face")
        {
            GameObject.Find("GameManager").GetComponent<OVRScreenFade>().FadeOut();
            Handler.ChangeSpectrum(ShaderIndex);
            gameObject.SetActive(true);
            
        }
        
    }

    IEnumerator FadeToNextShader()
    {

        yield return null;
    }


}
