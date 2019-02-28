using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{


    public float minRot;  // min starting rotation amount
    public float maxRot;   // max ""
    public GameObject gamecontrol;
    public GameObject floor;
    private Vector3 pos;   // position of the floor
    public float startRot; // starting rotation



    // Start is called before the first frame update
    void Start()
    {
        gamecontrol = GameObject.FindGameObjectWithTag("GameControl");
        floor = GameObject.Find("Base");
        pos = floor.transform.position;

        // value to randomly rotate floor by
        startRot = Random.Range(minRot, maxRot);

        // 50% to be negative rotation.
        if (Random.value > .5)
        {
            startRot = startRot * -1f;
        }

        floor.transform.SetPositionAndRotation(pos, Quaternion.Euler(0, 0 , startRot));

    }


}
