using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Application Version : " + Application.version;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
