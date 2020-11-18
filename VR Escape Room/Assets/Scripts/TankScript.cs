using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    public GameObject water;
    [SerializeField] private Animator TapAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Bucket_1_1" && TapAnimator.GetBool("isOn"))
        {
            water.SetActive(true);
        }
        
    }
}
