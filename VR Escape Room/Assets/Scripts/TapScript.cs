using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapScript : MonoBehaviour
{
    public GameObject tap;
    // Start is called before the first frame update
    void Start()
    {
        tap = GameObject.Find("Tap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TurnOnTheTap()
    {
        tap.SetActive(true);
    }
    
    
}
