using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AxisRawExample : MonoBehaviour
{
    public float range;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xpos = h * range;

        transform.position = new Vector3(xpos, 2f, 0);
        Debug.Log( "Value Returned: " + h.ToString("F2"));
    }
}
