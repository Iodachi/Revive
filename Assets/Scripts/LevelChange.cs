using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChange : MonoBehaviour {
    public PlayerControl player;

    // Use this for initialization
    void Start () {
        
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
            Scene sceneToLoad = SceneManager.GetSceneByName("level1");
            SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
            SceneManager.MoveGameObjectToScene(player.gameObject, sceneToLoad);

            //DontDestroyOnLoad(player.gameObject);
            //SceneManager.LoadScene("level1");
        }
    }
}
