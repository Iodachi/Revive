using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {

    public Text nameText;
    public Text dialogText;


    private string dialog2;

	// Use this for initialization
	void Start () {
	}
	
	// kinda hard coded since getKey not working in the startdialog method.
	void Update () {
        if (Input.GetKey(KeyCode.V) && dialogText.gameObject)
        {
            dialogText.text = dialog2;
        }
	}

    public void StartDialog (Dialog dialog){
        nameText.text = dialog.name;
        dialogText.text = dialog.sentences[0];

        dialog2 = dialog.sentences[1];

    }
      
    public void EndDialog(){
        nameText.gameObject.SetActive(false);
        dialogText.gameObject.SetActive(false);
    }

}
