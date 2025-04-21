using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered the " + gameObject.name + "object.");
    }
    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in the " + gameObject.name + "object.");
    }
    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left the " + gameObject.name + "object.");
    }


}
