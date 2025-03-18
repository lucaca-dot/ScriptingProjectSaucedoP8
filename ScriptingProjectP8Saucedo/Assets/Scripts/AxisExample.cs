using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xpos = h * range;

        transform.position = new Vector3(xpos, 2f, 0);
       Debug.Log ("value Returned: " + h.ToString("F2"));
    }
}
