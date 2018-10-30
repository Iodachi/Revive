using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LightChange : MonoBehaviour {
    Light lt;
    public Text instruction;

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
            ShowInstruction();
            if (Input.GetKeyDown("e"))
            {
                lt.intensity = 2;
                instruction.gameObject.SetActive(false);
            }
        }
    }

    void ShowInstruction(){
        instruction.text = "Press e to light it up!";
    }
}
