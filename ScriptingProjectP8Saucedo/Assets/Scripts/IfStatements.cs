using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotlimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
        
    }
    void TemperatureTest ()
    {
        //If it isn't, but the coffee temerature is greater than the hottest drinking temerature...
        if (coffeeTemperature > hotlimitTemperature)
        {
            // ... do this.
            print("coffee is Too hot.");
        }
        // if it isn't, but the cooffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("coffee is too cold.");
        }
        // If it is niether oof those then...
        else
        {
            // ... do this.
            print("coffee is just right.");
        }

    }
  

}
