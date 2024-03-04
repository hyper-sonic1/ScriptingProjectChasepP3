using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AxisExample : MonoBehaviour
{
    public float range;
    public Text textOutput;



    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizantal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log("value Returned: " + h.ToString("F2"));
    }
}
