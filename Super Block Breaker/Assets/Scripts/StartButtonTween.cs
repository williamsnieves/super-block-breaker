using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonTween : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, new Vector3(1.5f, 1.5f, 1.5f), 0.5f).setLoopPingPong();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
