using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeControl : MonoBehaviour {

    public PlayerControl player;
    public int changeColour;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        player.SetColour(changeColour);
    }
}