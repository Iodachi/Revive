using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour {

	public Dialog dialog;

    public Text dialogText;
    public Image image;
    private bool isIn;

    void Start()
    {
        image.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.V) && isIn)
        {
            dialogText.text = dialog.sentences[1];
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            dialogText.text = dialog.sentences[0];
            isIn = true;
            image.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            dialogText.text = "";
            isIn = false;
            image.gameObject.SetActive(false);
        }
    }
}
