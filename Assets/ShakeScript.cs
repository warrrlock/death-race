using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScript : MonoBehaviour
{

    public float JitterLoc;
    public float JitterAmplitude = 0.04f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time, JitterAmplitude) - JitterLoc;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);

    }
}
