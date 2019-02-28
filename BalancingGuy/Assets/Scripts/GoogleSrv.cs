using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;

public class GoogleSrv : MonoBehaviour
{
    public long time;
    public GameObject gameControl;

    private void Awake()
    {

        gameControl = GameObject.FindGameObjectWithTag("GameControl");
    }

    public float HighScore
    {
        get
        {
            return gameControl.GetComponent<HighScore>().highScore;
        }



    }

    public void Start()
    {

      
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        signIn();
        
    }

    // add to leader board
    public void AddToLeaderBrd(string id) {

        // in milli second
        double tempTime = HighScore * (double)100; // to get rid of the decimal we times by 100
       time = (long)tempTime * (long)10.0; 

        if (PlayGamesPlatform.Instance.IsAuthenticated())
        {
            
            Social.ReportScore(time, GPGSIds.leaderboard_all_time_best, (bool success) =>
            {
                if (success)
                    Debug.Log("new high score reported to google");

                Debug.Log("time in seconds :" + (long)HighScore);
                Debug.Log("time in milliseconds :" + time);
                //Social.ShowLeaderboardUI();
                if (!success)
                    Debug.Log("new high score not eported to google");// handle success or failure
            });

        }
    }





    void signIn()
    {
        Social.localUser.Authenticate(success => {

           
            if (success)
                Debug.Log("signed in to google services");
            else
                Debug.Log("could not sign in to google services");
        });
    }

}
