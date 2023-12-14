using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class translateItem : MonoBehaviour
{
    public string language;
    Text text;
    
    public string textRus;
    public string textEng;

    void Update()
    {
        text = GetComponent<Text>();
        language = PlayerPrefs.GetString("Lang");

        if(language == "" || language == "eng") //P.S. я ставлю инглиш как дефолт
        {
            text.text = textEng;
        }
        
        if (language == "Rus")
        {
            text.text = textRus;
        }
    }
}