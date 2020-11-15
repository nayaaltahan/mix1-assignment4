using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateButtonScript : MonoBehaviour
{
    public Animator animation;

    public string animationName;
    
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
        animation.enabled = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "LeftHandAnchor" || other.name == "RightHandAnchor")
        {
            if (animation.enabled == false)
            {
                animation.enabled = true;
            }
            animation.Play(animationName);
        }
    }
}
