using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    private void LateUpdate()
    {
        offset.z = -1;
        transform.position = target.position + offset;
    }
}
