using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject key; 
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
        if (other.name == "Bucket_1_1" && GameObject.Find("BucketWater").activeInHierarchy )
        {
            gameObject.SetActive(false);
            key.SetActive(true);
            key.GetComponent<OVRGrabbable>().enabled = true;
        }
    }
}
