using MyInput;
using UnityEngine;
public class Main : MonoBehaviour
{
    [SerializeField] private CameraFollower cameraFollower;
    
    [SerializeField] private ZeroToOneInput movementInput;
    [SerializeField] private ZeroToOneInput rotationDownInput;
    [SerializeField] private ZeroToOneInput rotationUpInput;

    [SerializeField] private CarMovement carMovement;
    [SerializeField] private CarRotator carDownRotator;
    [SerializeField] private CarRotator carUpRotator;

    private void Awake()
    {
        cameraFollower.Init(carMovement.transform);
        
        movementInput.Init(carMovement);
        rotationDownInput.Init(carDownRotator);
        rotationUpInput.Init(carUpRotator);
    }
}
