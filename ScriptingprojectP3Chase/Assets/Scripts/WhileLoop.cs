using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int cupsInTheSink = 4;


    // Start is called before the first frame update
    void Start()
    {
      while(cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
