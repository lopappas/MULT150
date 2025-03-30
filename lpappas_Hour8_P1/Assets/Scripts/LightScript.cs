using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    //public GameObject objectYouWant;
    // Start is called before the first frame update
    Light lightComponent; // A variable to store the light component.




    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.L)) {
            if (lightComponent.intensity == 5f)
            {
                lightComponent.intensity = 0f;
            }
            else
            {
                lightComponent.intensity = 5f;
            }
        }

        
        //GetComponent<LightScript>(getinput);
    }
}
