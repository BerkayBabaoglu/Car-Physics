using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
    public InputManager im;
    public List<WheelCollider> throttleWheels;
    public List<WheelCollider> steeringWheels;
    public List<GameObject> wheels;
    public float strenghtCoefficient = 10000f;
    public float maxTurn = 20f;

    private void Start()
    {
        im = GetComponent<InputManager>();
        
    }

    private void FixedUpdate()
    {
        foreach(WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = strenghtCoefficient * Time.deltaTime * im.throttle;
        }

        foreach(WheelCollider wheel in steeringWheels)
        {
            wheel.steerAngle = maxTurn * im.steer;

        }


    }


}
