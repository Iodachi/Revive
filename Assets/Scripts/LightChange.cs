using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LightChange : MonoBehaviour {
    Light lt;
    public Text instruction;
    bool isIn;

    // Use this for initialization
    void Start () {
        lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.E) && isIn)
        {
            Debug.Log("ee");
            lt.intensity = 2;
            instruction.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            ShowInstruction();
            isIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isIn = false;
        }
    }

    void ShowInstruction(){
        instruction.text = "Press [E] to light it up!";
    }
}
