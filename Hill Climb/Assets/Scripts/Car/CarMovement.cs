using UnityEngine;

public class CarMovement : MonoBehaviour, INormalizedProperty
{
    [SerializeField] private WheelJoint2D backWheel;
    [SerializeField] private WheelJoint2D frontWheel;
    [SerializeField] private float speed;
    public float ZeroToOne { set; get; }
    private void FixedUpdate()
    {
        if (ZeroToOne == 0)
        {
            backWheel.useMotor = false;
            frontWheel.useMotor = false;
        }
        else
        {
            backWheel.useMotor = true;
            frontWheel.useMotor = true;
            JointMotor2D motor2D = new JointMotor2D { motorSpeed = ZeroToOne * -speed, maxMotorTorque = 10000 };
            backWheel.motor = motor2D;
            frontWheel.motor = motor2D;
        }
    }
}
