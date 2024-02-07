using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource carRumble;
    // Start is called before the first frame update
    void Start()
    {
        carRumble.GetComponent<AudioSource>();
        //bgm.Play();
        carRumble.Play();
        carRumble.pitch = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        //solution 2 = try to lerp sound.
        if (Input.GetKey(KeyCode.W) && AccelerationScript.accValue > 0 && carRumble.pitch <= 1.5f)
        { //if acc value is increasing and pitch is not above 2.0
            carRumble.pitch += Time.deltaTime * 1.5f; //keep increasing pitch
        }
        else if(carRumble.pitch >= 0.5) {
            carRumble.pitch -= Time.deltaTime * 0.5f; //keep decreasing pitch
        }
    }
}
