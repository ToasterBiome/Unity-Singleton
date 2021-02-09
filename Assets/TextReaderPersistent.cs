using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextReaderPersistent : TextReaderArbirtrary
{
    private static TextReaderPersistent _instance;
    public static new TextReaderPersistent instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new TextReaderPersistent();
            }
            return _instance;
        }
    }

    private TextReaderPersistent() { }

    public override string ReadText(string fileName)
    {
        return base.ReadText(Path.Combine(Application.persistentDataPath,fileName));
    }

    
}
