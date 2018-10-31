using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogTrigger : MonoBehaviour {

    public Dialog dialog;
    public Text instruction;
    public Text nameText;
    public Text dialogText;

    private bool entered;
    private bool isIn;

    void Start(){
        instruction.gameObject.SetActive(false);
        entered = false;
    }

    // kinda hard coded since getKey not working in the startdialog method.
    void Update()
    {
        if (Input.GetKey(KeyCode.V) && isIn)
        {
            dialogText.text = dialog.sentences[1];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //only show when first entered
        if(other.tag == "Player" && !entered){
            StartDialog();
            instruction.gameObject.SetActive(true);
            entered = true;
            isIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            EndDialog();
            instruction.gameObject.SetActive(false);
            isIn = false;
        }
    }

    public void StartDialog()
    {
        nameText.text = dialog.name;
        dialogText.text = dialog.sentences[0];

    }

    public void EndDialog()
    {
        nameText.text = "";
        dialogText.text = "";
    }
}
