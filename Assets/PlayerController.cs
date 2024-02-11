using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //car acceleration and speed
    public float accelerationRate = 5f;
    public float decelerationRate = 2f;
    public float horizontalMovement = 4f;
    public float maxSpeed = 10f;

    public float minX = -25f;
    public float maxX = 25f;

    private float currentSpeed = 0f;

    //boost variables
    public Image boostBar;
    private float boostBarCurrent = 0f;
    public float boostBarRate = 5f;
    public float boostBarMax = 10f;

    //in BOOST variables
    public float speedBoostMultiplier = 1.5f; // Increase max speed during boost
    public float boostDuration = 3f;
    private bool isBoosting = false;

    //UI tesxt
    public TMP_Text speedCount;
    public TMP_Text boostText;

    //animator
    public Animator roadAnimator;

    void Update()
    {
        // Press vertical to go fast/slow and left/right
        float accelerationInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector3 newPosition = transform.position + new Vector3(horizontalInput * horizontalMovement * Time.deltaTime, 0, 0);

        // Clamp the x position
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);

        // Update the object's position
        transform.position = newPosition;


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
        roadAnimator.speed = currentSpeed / maxSpeed;

        // UI CODE //
        // Update the fill rate of the progress bar based on the current speed
        float fillRate = currentSpeed / maxSpeed;
        boostBar.fillAmount = fillRate;

        // Round the currentSpeed to the nearest integer
        int roundedSpeed = (int)currentSpeed;

        // Do something with the current speed value (e.g., print it)
        speedCount.text = "Speed: " + roundedSpeed;
    }

    IEnumerator ActivateBoost() //boosts acceleration rate for set duration
    {
        if (!isBoosting)
        {
            isBoosting = true;

            // Save the original max speed
            float originalMaxSpeed = accelerationRate;

            // Increase max speed during boost
            accelerationRate *= speedBoostMultiplier;

            // Wait for the boost duration
            yield return new WaitForSeconds(boostDuration);

            // Reset max speed to the original value
            accelerationRate = originalMaxSpeed;

            isBoosting = false;
        }
    }


}
