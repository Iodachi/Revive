using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChangeControl : MonoBehaviour {

    public PlayerControl player;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        player.SetColour(1);
    }
}