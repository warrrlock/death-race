using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePOVScript : MonoBehaviour
{
    public float POVReset;
    public float JitterLoc;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(640, 480, true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 0f), POVReset * Time.deltaTime);

        if (AccelerationScript.accValue >= 0.1)
        {
            float y = Mathf.PingPong(Time.time, 0.04f) - JitterLoc;
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
        
            transform.Rotate(new Vector3(0, 4, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -4, 0) * Time.deltaTime);
        }
    }
}
