using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public float accelerationRate = 5f;
    public float decelerationRate = 2f;
    public float maxSpeed = 10f;

    public float boostBarValue = 100f;

    private float currentSpeed = 0f;

    public Image speedBar;
    public TMP_Text speedCount;
    public TMP_Text boostText;

    // Boost variables
    public float boostMultiplier = 1.5f; // Increase max speed during boost
    public float boostDuration = 3f;
    private bool isBoosting = false;

    //Gear Variables -- finish the boosting first, make it feel good and then vary it up with this 
 /*   public int maxGears = 6;
    private int currentGear = 1; // current gear which contains its own maximumSpeed*/

    void Update()
    {
        // Input for acceleration (e.g., pressing a key)
        float accelerationInput = Input.GetAxis("Vertical");

        // Calculate new speed using acceleration
        currentSpeed += accelerationInput * accelerationRate * Time.deltaTime;

        // Apply deceleration over time
        currentSpeed -= decelerationRate * Time.deltaTime;

        // Check if boost can be activated
        if (currentSpeed >= 80f && currentSpeed <= 100f && Input.GetKeyDown(KeyCode.Space) && isBoosting == false)
        {
            StartCoroutine(ActivateBoost());
        }

        // Clamp the speed to the maximum speed
        currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);

        // Update the fill rate of the progress bar based on the current speed
        float fillRate = currentSpeed / maxSpeed;
        speedBar.fillAmount = fillRate;

        // Round the currentSpeed to the nearest integer
        int roundedSpeed = (int)currentSpeed;

        // Do something with the current speed value (e.g., print it)
        speedCount.text = "Speed: " + roundedSpeed;
        Debug.Log("Current Speed: " + roundedSpeed);
    }

    IEnumerator ActivateBoost() //boosts acceleration rate for set duration
    {
        if (!isBoosting)
        {
            isBoosting = true;

            // Save the original max speed
            float originalMaxSpeed = accelerationRate;

            // Increase max speed during boost
            accelerationRate *= boostMultiplier;

            // Wait for the boost duration
            yield return new WaitForSeconds(boostDuration);

            // Reset max speed to the original value
            accelerationRate = originalMaxSpeed;

            isBoosting = false;
        }
    }

}
