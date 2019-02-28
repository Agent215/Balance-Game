using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMan : MonoBehaviour

{
    public float rawTime;  // time as a float
    public double timer;
    private GameObject TimeText;
    private GameObject gamecontrol;


    // Start is called before the first frame update
    void Start()
    {
        gamecontrol = GameObject.FindGameObjectWithTag("GameControl");
        TimeText = GameObject.Find("Time");
        timer = 0;
        rawTime = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (gamecontrol.GetComponent<GameMan>().GameActive)
        rawTime += Time.deltaTime;
        timer = System.Math.Round(rawTime, 2);
    }
}
