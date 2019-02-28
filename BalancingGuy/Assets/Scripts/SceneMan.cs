using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{

    public void StartGame()
    {


        Debug.Log("button down");

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");


    }
}
