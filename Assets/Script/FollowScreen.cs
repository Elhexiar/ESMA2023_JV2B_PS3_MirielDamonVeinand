using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class FollowScreen : MonoBehaviour
{

    [SerializeField]
    private Vector3 tempPosition;
    public Vector3 position;
    public bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.touchCount > 0 && active)
        {
            Camera mainCamera = Camera.main;
            tempPosition = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, mainCamera.nearClipPlane + 10 - 0.3f);
            transform.position = mainCamera.ScreenToWorldPoint(tempPosition);
            transform.position = new Vector3(transform.position.x, transform.position.y, -2f);
        }
    }
}
