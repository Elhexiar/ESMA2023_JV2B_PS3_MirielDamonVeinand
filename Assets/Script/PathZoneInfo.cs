using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PathZoneInfo : MonoBehaviour
{
    public bool hideAfterTouch = false;
    private GameObject currentZoneObject;
    public UnityEvent eventList;

    public 
    // Start is called before the first frame update
    void Start()
    {
        currentZoneObject = gameObject;
    }
     
    IEnumerator TaskToDo()
    {

        eventList.Invoke();

        yield return null;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
