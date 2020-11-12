using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScriptt : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform _transform;
    void Start()
    {
        _transform = GameObject.Find("button1").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LeftHandAnchor")
        {
            //_transform.position(Vector3.down, 0.01);
            //_transform.position.y = transform.position.y - 0.01;
            _transform.Translate(Vector3.down*0.1f,Space.Self);
            Debug.Log("55555555");
        }
        
        
    }
    private void OnTriggerExit(Collider other)
    {
      //  _transform.Translate(Vector3.up*0.1f,Space.Self);
    }
}
