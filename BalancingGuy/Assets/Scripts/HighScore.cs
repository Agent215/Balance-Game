using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HighScore : MonoBehaviour
{
    public float highScore;

    // Start is called before the first frame update
    void Awake()
    {
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
    }


    public void setHighScore() {

        PlayerPrefs.SetFloat("HighScore", (float)GameObject.FindGameObjectWithTag("GameControl").GetComponent<TimerMan>().timer);
        highScore = PlayerPrefs.GetFloat("HighScore");
        Debug.Log("player preds are " + PlayerPrefs.GetFloat("HighScore"));

    }

   



   
}
