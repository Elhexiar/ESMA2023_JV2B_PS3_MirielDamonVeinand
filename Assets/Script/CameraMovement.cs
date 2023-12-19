using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target;
    private Vector3 targetPosition;
    private Vector3 targetRotation;

    private Vector3 origin;
    private Vector3 originRotation;
    public float value;
    public float frequencie;
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        targetPosition = target.position;
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        value = 0.5f + (Mathf.Sin(Time.time * frequencie)/2);
        transform.position = Vector3.Lerp(origin, targetPosition, value);
        
    }
}
