using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;


public class HighScoreDisplay : MonoBehaviour
{
    public GameObject gameControl;
    public Text bestTime;
    

    public float HighScore
    {
        get
        {
            return gameControl.GetComponent<HighScore>().highScore;
        }



    }

    private void Awake()
    {
      
        gameControl = GameObject.FindGameObjectWithTag("GameControl");

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if game is over then display high score
        if (!gameControl.GetComponent<GameMan>().GameActive)
        {
            bestTime.text = "BEST TIME : " + HighScore;

          
        }
    }
}
