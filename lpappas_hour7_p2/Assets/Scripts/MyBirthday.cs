using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int birthday = 15;

        for (int i = 1; i < 29; i++)
        {
            if (i != birthday)
            {
                Debug.Log(i);
            }
            else
            {
                Debug.Log("It's my birthday!");
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
