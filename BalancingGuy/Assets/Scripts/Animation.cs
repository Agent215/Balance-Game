using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject RestartUI;
    public GameObject animator;
    public void AnimateRestart() {


        if (RestartUI != null) {


            bool isOpen = animator.GetComponent<Animator>().GetBool("open");

            Debug.Log("animation starts");
            animator.GetComponent<Animator>().SetBool("open", !isOpen);
        }

    }
}
