using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour
{

    public Text currentTime;
   
    public GameObject gameControl;
    
    private void Awake()
    {
        gameControl = GameObject.FindGameObjectWithTag("GameControl");
      

    }

 
    // Update is called once per frame
    void Update()
    {


        currentTime.text = "TIME : " + gameControl.GetComponent<TimerMan>().timer;

      
}


}
