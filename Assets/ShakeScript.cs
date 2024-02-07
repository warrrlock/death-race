using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScript : MonoBehaviour
{

    public float JitterLoc;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.PingPong(Time.time, 0.04f) - JitterLoc;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);

    }
}
