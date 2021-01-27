using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finding_Word : MonoBehaviour
{
    public string findWord;
    public GameObject inputField;
    public GameObject textDisplay;

    public void Names()
    {

        findWord = inputField.GetComponent<Text>().text;

        if (findWord == "Football")
        {
            textDisplay.GetComponent<Text>().text = " ["+ findWord +"] "+"is found ";
        }
        else if (findWord == "Basketball")
        {
            textDisplay.GetComponent<Text>().text = " ["+ findWord +"] "+"is found ";
        }
        else if (findWord == "Golf")
        {
            textDisplay.GetComponent<Text>().text = " ["+ findWord +"] "+"is found ";
        }
        else if (findWord == "Tennis")
        {
            textDisplay.GetComponent<Text>().text = " ["+ findWord +"] "+"is found ";
        }
        else if (findWord == "Handball")
        {
            textDisplay.GetComponent<Text>().text = " ["+ findWord +"] "+"is found ";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = " ["+ findWord +"] "+"not found ";
        }


    }
}
 
