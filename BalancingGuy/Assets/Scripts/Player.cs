using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
        Debug.Log("game has began");
        GameObject.FindGameObjectWithTag("Restart").SetActive(false);
    }

   
}
