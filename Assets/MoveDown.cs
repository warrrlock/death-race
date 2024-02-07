using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AccelerationScript.accValue >= 0.1)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(8.16f, -3.4f, 1.9f), 0.00005f); //moon go down
        }
    }
}
