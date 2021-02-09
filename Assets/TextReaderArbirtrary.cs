using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextReaderArbirtrary
{
    private static TextReaderArbirtrary _instance;
    public static TextReaderArbirtrary instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new TextReaderArbirtrary();
            }
            return _instance;
        }
    }

    protected TextReaderArbirtrary() { }

    public virtual string ReadText(string path)
    {
        return File.ReadAllText(path);
    }

    
}
