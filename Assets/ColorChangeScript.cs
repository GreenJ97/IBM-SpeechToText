using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeScript : MonoBehaviour
{
    public GameObject STT;
    private SpeechToTextScript _theSpeechToText;
    private Renderer _renderer;
    private string finalTranscript;


    private string[] keywordStrings;
    private string theActiveKeyword;

    

    // Start is called before the first frame update
    void Start()
    {
        _theSpeechToText = STT.GetComponent<SpeechToTextScript>();
        _renderer = this.GetComponent<Renderer>();

        
        keywordStrings = new string[3] { "blue", "yellow", "red" };
        _theSpeechToText.SetKeywords(keywordStrings);
    }

    // Update is called once per frame
    void Update()
    {
        CheckColour();
    }

    public void CheckColour()
    {
        theActiveKeyword = _theSpeechToText.GetCurrentKeyword();

        if(string.Equals(theActiveKeyword, keywordStrings[0]))
        {
            _renderer.material.SetColor("_Color", Color.blue);
        }

        if(string.Equals(theActiveKeyword, keywordStrings[1]))
        {
            _renderer.material.SetColor("_Color", Color.yellow);
        }

        if(string.Equals(theActiveKeyword, keywordStrings[2]))
        {
            _renderer.material.SetColor("_Color", Color.red);
        }
    }

    //public void CheckColour()
    //{
    //    finalTranscript = _theSpeechToText.GetFinalTranscript();

    //    if (string.Equals(finalTranscript, "blue "))
    //    {
    //        _renderer.material.SetColor("_Color", Color.blue);
    //    }

    //    if (string.Equals(finalTranscript, "yellow "))
    //    {
    //        _renderer.material.SetColor("_Color", Color.yellow);
    //    }

    //    if (string.Equals(finalTranscript, "red "))
    //    {
    //        _renderer.material.SetColor("_Color", Color.red);
    //    }

    //}
}
