using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachPlayer : MonoBehaviour {

    public GameObject Player;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if (other.tag == "Player")
        {
            Player.transform.parent = this.transform.parent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.transform.parent = null;
        }
    }
}
