using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CursorBehaviour : MonoBehaviour
{
    public Cursor parentCursor;

    public Transform leftLimit;
    public Transform rightLimit;
    public Vector3 spawn, endLimit;
    public int timer = 0;
    public int timerLimit = 200;
    public float currentRelativePosition;
    public float fwdOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentRelativePosition = (float)timer/timerLimit;

        if(leftLimit != null)
        {
            gameObject.transform.position = Vector3.Lerp(leftLimit.position, rightLimit.position, currentRelativePosition);
        }
        else
        {
            gameObject.transform.position = Vector3.Lerp(spawn, endLimit, currentRelativePosition);
        }

        
        gameObject.transform.position += Vector3.back * fwdOffset;
        timer++;

        if (timer >= timerLimit)
        {
            parentCursor.cursorHitLimit();
        }
    }
}
