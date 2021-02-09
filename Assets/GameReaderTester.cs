using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameReaderTester : MonoBehaviour
{

    public TextAsset textAsset;
    public string arbPath;
    public string perPath;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TextReaderTextAsset.instance.ReadText(textAsset));
        Debug.Log(TextReaderArbirtrary.instance.ReadText(arbPath));
        Debug.Log(TextReaderPersistent.instance.ReadText(perPath));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
