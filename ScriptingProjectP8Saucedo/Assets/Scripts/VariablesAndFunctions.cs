using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VariablesAndFunctions : MonoBehaviour
{
    //Creat a variable of type integer
    int MyInt = 15;


    // Start is called before the first frame update
    void Start()
    {
        //I am going to run my int through my function to multiply it by two
        MyInt = MultiplyByTwo(MyInt);

        // I'm going to print my results to the consoole
        Debug.Log(MyInt);

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Creating a function that takes a int parameter and multiply it by 2
    int MultiplyByTwo(int number)
    {
    //Creating a variable to store my results
   
        int results;
        //multiplying the passed parameter by 2
        results = number * 2;

        //Returning the results
        return results;
    }
}

