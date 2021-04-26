using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    float maxSpeed;
    float steerAngle;
    Rigidbody carBody;
    public WheelCollider backRight;
    public WheelCollider frontRight;
    public WheelCollider backLeft;
    public WheelCollider frontLeft;
    void Start()
    {
        maxSpeed = 3500f;
        steerAngle = 30f;
        carBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        carBody.centerOfMass = new Vector3(0f, -0.9f, 0f);

    }
    void FixedUpdate()
    {
        float currentSpeed = maxSpeed * Input.GetAxis("Vertical");
        frontLeft.motorTorque = currentSpeed;
        frontRight.motorTorque = currentSpeed;
        float steering = steerAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = steering;
        frontRight.steerAngle = steering;
    }
}
