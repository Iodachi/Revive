using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instruction : MonoBehaviour {

    public Dialog dialog;
    public Text instruction;
    public Text nameText;
    public Text dialogText;
    public Image image;

    private bool isIn;
    private int index = 0;

    void Start()
    {
        instruction.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
    }

    // kinda hard coded since getKey not working in the startdialog method.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V) && isIn)
        {
            dialogText.text = dialog.sentences[index];

            if (index < dialog.sentences.Length - 1)
            {
                index++;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //only show when first entered
        if (other.tag == "Player")
        {
            StartDialog();
            isIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            EndDialog();
            isIn = false;
        }
    }

    public void StartDialog()
    {
        image.gameObject.SetActive(true);
        instruction.gameObject.SetActive(true);
        nameText.text = dialog.name;
        dialogText.text = dialog.sentences[0];
        index++;
    }

    public void EndDialog()
    {
        nameText.text = "";
        dialogText.text = "";
        instruction.gameObject.SetActive(false);
        image.gameObject.SetActive(false);
        index = 0;
    }
}
