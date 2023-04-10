using UnityEngine;

public class CarRotator : MonoBehaviour, INormalizedProperty
{
    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private float rotationSpeed;

    private void FixedUpdate()
    {
        rigidbody2D.AddTorque(ZeroToOne * rotationSpeed * Time.fixedDeltaTime);
    }

    public float ZeroToOne { get; set; }
}