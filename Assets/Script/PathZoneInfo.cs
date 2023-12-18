using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.UI;


public class PathZoneInfo : MonoBehaviour
{
    public bool hideAfterTouch = false;
    private GameObject currentZoneObject;
    public UnityEvent eventList;
    public bool needToBeHeld = false;

    public int holdingTimer = 0;
    public int holdingTimerLimit = 0;
    public string instructions;
    public bool touchable = true;

    
    public UnityEngine.UI.Slider timeSlider;
    public int test;

     
    // Start is called before the first frame update
    void Start()
    {

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
