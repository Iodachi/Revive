using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {
    public PlayerControl player;
    private string level;

    // Use this for initialization
    void Start () {
        Scene scene = SceneManager.GetActiveScene();
        level = scene.name.Substring(5);
        Debug.Log("level: " + level);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //if player fulfilled the task
        if(other.tag == "Player"){
            if(level == "0"){
                if(player.getFlowers() >= 5 && player.playerHaveBow()){
                    SceneManager.LoadScene("level1");
                }
            }else if(level == "1"){
                SceneManager.LoadScene("level2");
            }
        }
    }

}
