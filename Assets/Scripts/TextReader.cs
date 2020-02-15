using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextReader : MonoBehaviour
{
    string textContent;
    
    public string ReadTextFile(string textFileName)
    {
        TextAsset textAsset = (TextAsset)Resources.Load(textFileName);

        return textAsset.text;
    }
}
