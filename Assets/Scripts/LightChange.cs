using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChange : MonoBehaviour {
    Light lt;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        lt = GetComponent<Light>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            //if(Input.GetKeyDown("e"))
                lt.intensity = 2;
        }
    }
}
