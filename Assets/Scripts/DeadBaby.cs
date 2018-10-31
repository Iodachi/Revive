using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeadBaby : MonoBehaviour {
    public Dialog dialog;

    public Text nameText;
    public Text dialogText;

    private void OnTriggerEnter(Collider other){

        if (other.tag == "Player")
        {
            nameText.text = dialog.name;
            dialogText.text = dialog.sentences[0];
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            nameText.text = "";
            dialogText.text = "";
        }
    }
}
