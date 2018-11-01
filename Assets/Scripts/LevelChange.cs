using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {
    public PlayerControl player;

    // Use this for initialization
    void Start () {
        Scene scene = SceneManager.GetActiveScene();
        string level = scene.name.Substring(5);
        Debug.Log("level: " + level);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //if player fulfilled the task
        if(other.tag == "Player" 
           //&& player.getFlowers() >= 5
          ){
            SceneManager.LoadScene("level1");
        }
    }
}
