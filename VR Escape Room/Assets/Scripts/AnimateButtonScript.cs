using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateButtonScript : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    [SerializeField] private Animator TapAnimator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "LeftHandAnchor" || other.name == "RightHandAnchor")
        {
            myAnimationController.SetBool("pressButton", true);
            if (gameObject.name == "Button 4")
            {
                TapAnimator.SetBool("isOn", true);
                GameObject.Find("Tap").GetComponent<AudioSource>().enabled = true;
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "LeftHandAnchor" || other.name == "RightHandAnchor")
        {
            myAnimationController.SetBool("pressButton", false);
        }
    }
}
