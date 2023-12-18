using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class ZoneManager : MonoBehaviour
{

    public List<GameObject> zonesList = new List<GameObject>();
    [SerializeField] public int CurrentZoneIndex;
    private StepsManager myStepsManager;
    [SerializeField] private bool currentStepConditionCompleted;
    // Start is called before the first frame update
    void Start()
    {

        // Makes Sure that only the first zone is active
        foreach (var item in zonesList)
        {
            item.SetActive(false);
        }
        zonesList[CurrentZoneIndex].SetActive(true);
        myStepsManager = GetComponentInParent<StepsManager>();
    }

    // Update is called once per frame
    void Update()
    {


        if(Input.touchCount > 0)
        {
            Camera myCamera = Camera.main;
            Vector3 screenTouchPos = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, myCamera.farClipPlane);
            Vector3 touchPosWorld = myCamera.ScreenToWorldPoint(screenTouchPos);
            Debug.DrawLine(myCamera.transform.position, touchPosWorld, Color.red);
            if(Physics.Raycast(myCamera.transform.position, touchPosWorld - myCamera.transform.position, out var info))
            {
                //Debug.Log("yo");

                //Colliding zones
                if (info.collider.gameObject == zonesList[CurrentZoneIndex] && zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>().touchable == true)
                {
                    var currentPathInfo = zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>();
                    if (currentPathInfo.needToBeHeld)
                    {
                        currentPathInfo.holdingTimer++;
                        if(currentPathInfo.timeSlider != null)
                        {
                            currentPathInfo.timeSlider.value = (float)currentPathInfo.holdingTimer/ (float)currentPathInfo.holdingTimerLimit;
                        }
                        if(currentPathInfo.holdingTimer >= currentPathInfo.holdingTimerLimit)
                        {
                            ProceedToNextZone();
                        }
                    }
                    else
                    {
                        ProceedToNextZone();
                    }
                }
            }


        }
        
    }

    public void ProceedToNextZone()
    {
        //Debug.Log("SUCCES");
        zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>().StartCoroutine("TaskToDo");

        

        CurrentZoneIndex++;
        if (CurrentZoneIndex >= zonesList.Count)
        {
            Debug.Log("LAST ZONE");
            myStepsManager.nextStepInvoked = true;
        }
        else
        {
            
            zonesList[CurrentZoneIndex].SetActive(true);
        }
    }

}
