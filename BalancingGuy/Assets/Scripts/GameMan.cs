using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GameMan : MonoBehaviour
{
    public GameObject startUI;
    public GameObject player;
    public bool GameActive;
    public void Start()
    {
      
        player.SetActive(false);
      
    }

    public void SetGameActive() {

        startUI.SetActive(false);
        GameActive = true;
        player.SetActive(true);

    }


    public void SetGameInactive() {

        GameActive = false;
     
    }

    public bool getGameActive() {
        return GameActive;
    }
}
