using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tentacles : MonoBehaviour {
    public Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.position = respawnPoint.transform.position;
        }
    }
}
