using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float cloudMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AccelerationScript.accValue <= 0)
        {
            transform.Translate(0, 0, -0.5f * Time.deltaTime);
        }
        else if (AccelerationScript.accValue >= 0.1) 
        {
            transform.Translate(0, 0, -cloudMove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A) && AccelerationScript.accValue >= 0.1)
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D) && AccelerationScript.accValue >= 0.1)
        {
            transform.Translate(5 * Time.deltaTime, 0, 0);
        }

        if (transform.position.z <= -8.5f )
        {
            transform.position = new Vector3(Random.Range(-15, 30), Random.Range(6, 8), -1.2f);
        }
    }

}
