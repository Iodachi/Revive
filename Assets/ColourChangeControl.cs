<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
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
>>>>>>> 7cb96a7c3d01e6536c2b1b3a7f2517be11a0872d
