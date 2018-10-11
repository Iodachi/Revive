using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    MeshRenderer Mesh;

	// Use this for initialization
	void Start () {
        Mesh = GetComponent<MeshRenderer>();
        Mesh.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void LightTurnOn()
    {
        Mesh.enabled = true;
    }
}
