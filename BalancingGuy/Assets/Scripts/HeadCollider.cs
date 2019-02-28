using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;

public class HeadCollider : MonoBehaviour
{

    public GameObject restartButton;
    //public GameObject Time;
    //public GameObject GameOverText;
    public GameObject rotateButton1;
    public GameObject rotateButton2;
    public GameObject gameControl;
    private bool isActive;



    private void Awake()
    {

        gameControl = GameObject.FindGameObjectWithTag("GameControl");

    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Respawn" )
        {
            
            Debug.Log("head collided");
           // GameObject.FindGameObjectWithTag("Restart").SetActive(true);

            //display restart button
            restartButton.SetActive(true);
            gameControl.GetComponent<GameMan>().SetGameInactive();


            //check if new high score.
            if (PlayerPrefs.GetFloat("HighScore") < (float)GameObject.FindGameObjectWithTag("GameControl").GetComponent<TimerMan>().timer)
            {
                GameObject.FindGameObjectWithTag("GameControl").GetComponent<HighScore>().setHighScore();
                gameControl.GetComponent<GoogleSrv>().AddToLeaderBrd("CgkIuMv5hccDEAIQAg");

            }

            //Time.SetActive(true);
            //GameOverText.SetActive(true);

            //remove rotate buttons
            rotateButton1.SetActive(false);
            rotateButton2.SetActive(false);
        }
    }

    

}
