using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform target;
    [SerializeField]
    Vector2 offset;
    [SerializeField]
    float damping;

    Vector3 velocity = Vector3.zero;
    private void FixedUpdate()
    {
        Vector3 movePosition = new Vector3 (target.position.x , target.position.y , transform.position.z) + new Vector3 ( offset.x , offset.y , 0);
        transform.position = Vector3.SmoothDamp(transform.position, movePosition, ref velocity, damping);
        
    }
}
