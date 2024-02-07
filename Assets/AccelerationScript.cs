using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerationScript : MonoBehaviour
{

    private Animator roadAnim;
    public static float accValue;

    //public float newAnimationSpeed = 1.3f;


    // Start is called before the first frame update
    void Start()
    {
        roadAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && accValue <= 1.3f) {
            roadAnim.SetFloat("Accelerate", accValue+=0.005f);
            Debug.Log("Accelerate");
        }
        else if (Input.GetKey(KeyCode.S) && accValue >= 0f)
        {
            roadAnim.SetFloat("Accelerate", accValue -= 0.001f);
            Debug.Log("Deceelerate");
        }

        if (accValue >= 0)
        {
            roadAnim.SetFloat("Accelerate", accValue -= 0.001f);
        }
            //Debug.Log("" + accValue);
    }
}
