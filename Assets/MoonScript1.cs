using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonScript1 : MonoBehaviour
{
    public float moonMove;
    public float moonReset;
    public float scaleSpeed;
    public float downspeed;
    public float rayLength;

    public Vector3 destination;
    public Vector3 destination2;
    public Vector3 moonScale;
    public Vector3 moonEndScale;

    public Transform POrigin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        RaycastHit hit;
       

        //raycast code
        Debug.DrawRay(transform.position, POrigin.position - transform.position, Color.white); //display ray debug

        if (Physics.Linecast(transform.position, POrigin.position - transform.position, out hit))
        {
            
                Debug.Log("HitCloud");
            
        }
        //raycast code

        if (AccelerationScript.accValue >= 0.1)
        {
            transform.position = Vector3.Lerp(transform.position, destination2, downspeed); //moon go down
        }

        transform.localScale = Vector3.Lerp(moonScale, moonEndScale, scaleSpeed); //moon go big


        if (Input.GetKey(KeyCode.A) && AccelerationScript.accValue > 0)
        {
            //transform.Translate(moonMove * Time.deltaTime, 0, 0); //move to A side
            //transform.position = Vector3.Lerp(transform.position, destination, moonReset); //if steering A, reset back
        }

        if (Input.GetKey(KeyCode.D) && AccelerationScript.accValue > 0)
        {
            transform.Translate(-moonMove * Time.deltaTime, 0, 0);
            //transform.position = Vector3.Lerp(transform.position, destination, moonReset);
        }
    }
}
