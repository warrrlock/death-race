using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    Transform moon;
    Text Quotes;


    // Start is called before the first frame update
    void Start()
    {
        Quotes = GameObject.Find("Quote1").GetComponent<Text>();
        moon = GameObject.Find("Moon").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Quotes.text = "";

        if (moon.position.y <= 18 && moon.position.y >= 17.5f)
        {
            Quotes.text = "                                       hey...";
        }

        if (moon.position.y <= 17f && moon.position.y > 16f) {
            Quotes.text = "   the clouds are rolling in...";
        }

        if (moon.position.y <= 15.5f && moon.position.y >= 14f)
        {
            Quotes.text = "       keep an eye out for me.";
        }

        if (moon.position.y <= 13.5f && moon.position.y >= 12.5f)
        {
            Quotes.text = "              it's a lonely night...";
        }

        if (moon.position.y <= 11.5 && moon.position.y >= 10f)
        {
            Quotes.text = "        aren't you lonely too?";
        }

        if (moon.position.y <= 9.5 && moon.position.y >= 8.5f)
        {
            Quotes.text = "          I'll be going soon...";
        }

        if (moon.position.y <= 8 && moon.position.y >= 7.5f)
        {
            Quotes.text = "you'll be okay without me.";
        }

        if (moon.position.y <= 7 && moon.position.y >= 6f)
        {
            Quotes.text = "                                right?";
        }

        if (moon.position.y <= 3.5f && moon.position.y >= 2.8f)
        {
            Quotes.text = "      ...I'll see you around.";
        }

        //transform.position = Vector3.Lerp(transform.position, new Vector3(345.2f, -196.4f, 0), 0.000001f); //move down
    }
}
