using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateButtonMan : MonoBehaviour
{
 
    public GameObject gamecontrol;
    public GameObject floor;
    private float rotationAmount; // amount to move floor by each click
    public bool leftPress;
    public bool rightPress;

    
    void Start()
    {
      
        gamecontrol = GameObject.FindGameObjectWithTag("GameControl");
        leftPress = false;
        rightPress = false;
        floor = GameObject.Find("Base");
    

    }

    private void FixedUpdate()
    {
        rotationAmount = floor.GetComponent<Transform>().rotation.eulerAngles.z;

        if (leftPress == true)
            floor.transform.Rotate(0, 0, 1 * -.4f);
            //floor.transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(rotationAmount, rotationAmount - 1f, Time.deltaTime * .5f));
        if (rightPress == true)
            floor.transform.Rotate(0, 0, 1 * .4f);
           // floor.transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(rotationAmount, rotationAmount + 1f, Time.deltaTime * .5f));

    }

    public void RotateLeft()
    {
        gamecontrol.GetComponent<GameMan>().SetGameActive();
        Debug.Log("left Button Pressed");
        leftPress = true;
        StartCoroutine(Wait(.3f));
        // floor.transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(rotationAmount, rotationAmount - 20, Time.deltaTime * 20f));
        // floor.transform.Rotate(0, 0, 1 * -.9f);
    }

    public void RotateRight()
    {
        gamecontrol.GetComponent<GameMan>().SetGameActive();
        Debug.Log("right Button Pressed");
        rightPress = true;
       StartCoroutine (Wait(.3f));
       
        // floor.transform.Rotate(0, 0, 1 * .9f);


      //  floor.transform.rotation = Quaternion.Euler(0f, 0f, Mathf.Lerp(rotationAmount, rotationAmount + 20, Time.deltaTime * 20f));
    }

    
    IEnumerator Wait(float timeToWait)
    {
        
            yield return new WaitForSeconds(timeToWait);
            rightPress = false;
            leftPress = false;
        
    }

}
