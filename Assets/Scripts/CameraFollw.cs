using UnityEngine;

public class CameraFollw : MonoBehaviour
{
    public GameObject targetObject;
    public Vector3 cameraOffset;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = targetObject.transform.position + cameraOffset;
    }
}
