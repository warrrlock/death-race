using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    public float roadmove;
    public float roadreset;
    public float roadRotReset;
    public Vector3 destination;
    

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, destination, roadreset);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, 0f), roadRotReset * Time.deltaTime);

        if (Input.GetKey(KeyCode.A) && AccelerationScript.accValue > 0)
        {
            transform.Translate(roadmove * Time.deltaTime, 0, 0);
            transform.Rotate(new Vector3(0, 5, 0)*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) && AccelerationScript.accValue > 0)
        {
            transform.Translate(-roadmove * Time.deltaTime, 0, 0);
            transform.Rotate(new Vector3(0, -5, 0) * Time.deltaTime);
        }
    }

}
