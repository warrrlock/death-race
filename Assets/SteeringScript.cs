using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringScript : MonoBehaviour
{
    public float steerSpeed;
    public float steerResetSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 0f), steerResetSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(new Vector3(0, 0, steerSpeed) * Time.deltaTime);
            Debug.Log("Left");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, -steerSpeed) * Time.deltaTime);
            Debug.Log("Right");
        }
    }
}
