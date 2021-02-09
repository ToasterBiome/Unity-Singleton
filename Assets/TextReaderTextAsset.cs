using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextReaderTextAsset
{
    private static TextReaderTextAsset _instance;
    public static TextReaderTextAsset instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new TextReaderTextAsset();
            }
            return _instance;
        }
    }

    private TextReaderTextAsset() { }

    public string ReadText(TextAsset asset)
    {
        return asset.text;
    }
}
