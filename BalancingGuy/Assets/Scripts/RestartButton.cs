using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
   

    public void ReStart() {


        Debug.Log("button down");
       
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("SampleScene");
      

    }
}
