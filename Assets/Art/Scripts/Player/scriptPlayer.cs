using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayer : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10;
    [SerializeField] private float acceleration = 10;
    [SerializeField] private float maxAcceleration = 300f;
    private bool isAlive = true;
    private Rigidbody2D rb;
    [SerializeField] private float fuel = 1000;

    // Start is called before the first frame update
    void Start()
    {
        isAlive = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            float dirRotation = Convert.ToInt32(Input.GetKey(KeyCode.LeftArrow)) - Convert.ToInt32(Input.GetKey(KeyCode.RightArrow));
            float dirPropultion = Convert.ToInt32(Input.GetKey(KeyCode.UpArrow)) - Convert.ToInt32(Input.GetKey(KeyCode.DownArrow));

            if (dirRotation != 0)
                AddTorqueImpulse(dirRotation * rotationSpeed * Time.deltaTime);
            if (dirPropultion != 0)
                AddSpeed(dirPropultion * acceleration * Time.deltaTime);
            if (fuel <= 0)
                isAlive = false;
        }

    }

    private void AddSpeed(float accelerationSpeed)
    {
        rb.AddForce(accelerationSpeed * transform.up);
    }

    // Add an impulse which produces a change in angular velocity (specified in degrees).
    private void AddTorqueImpulse(float angularChangeInDegrees)
    {
        var impulse = (angularChangeInDegrees * Mathf.Deg2Rad);
        rb.AddTorque(impulse, ForceMode2D.Impulse);
        fuel -= 1 * Time.deltaTime;
    }
    
}