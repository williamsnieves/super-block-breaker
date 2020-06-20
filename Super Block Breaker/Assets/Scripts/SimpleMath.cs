using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMath : MonoBehaviour
{
    float numberChallenge = 6.2f;
    int remainder = 0;
    // Start is called before the first frame update
    void Start()
    {
        remainder = 126 % 4;
        Debug.Log(remainder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
