using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int healthpoints = 3992;
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        Debug.Log("Healtpoints: " + healthpoints.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static int UsePotion(int health)
    {
        return  health + 400;
    }
}
