using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTrigger : MonoBehaviour {

    public Dialog dialog;
    public DialogManager manager;
    public Text instruction;

    void Start(){
        manager = FindObjectOfType<DialogManager>();
        instruction.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            Debug.Log("entered");
            manager.StartDialog(dialog);
            instruction.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            FindObjectOfType<DialogManager>().EndDialog();
            instruction.gameObject.SetActive(false);
        }
    }
}
