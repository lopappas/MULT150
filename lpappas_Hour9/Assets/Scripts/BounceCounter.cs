using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int bounceCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (OnTriggerEnter(Collider other) == true)
        //{

        //}
    }

    void OnTriggerEnter(Collider other)
    {
        bounceCount++;
        Debug.Log(bounceCount);

    }
}
