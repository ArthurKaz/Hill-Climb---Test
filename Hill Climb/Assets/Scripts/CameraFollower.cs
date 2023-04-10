using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothing = 5f;
    private Transform _target;

    public void Init(Transform target)
    {
        _target = target;
    }

    private void FixedUpdate()
    {
        Vector3 targetCamPos = _target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
