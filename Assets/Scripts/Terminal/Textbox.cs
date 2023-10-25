using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Textbox : MonoBehaviour
{
    TMP_InputField input;

    public void SendText()
    {
        PlayerMovement.instance.SelectCommand(input.text);
        input.text = "";
    }



    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<TMP_InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
