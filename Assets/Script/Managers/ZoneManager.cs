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
        zonesList[0].SetActive(true);
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
                    if(zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>().needToBeHeld)
                    {
                        zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>().holdingTimer++;
                        if(zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>().holdingTimer >= zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>().holdingTimerLimit)
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

    void ProceedToNextZone()
    {
        //Debug.Log("SUCCES");
        zonesList[CurrentZoneIndex].GetComponent<PathZoneInfo>().StartCoroutine("TaskToDo");


        CurrentZoneIndex++;
        if (CurrentZoneIndex >= zonesList.Count)
        {
            myStepsManager.nextStepInvoked = true;
        }
        else
        {
            zonesList[CurrentZoneIndex].SetActive(true);
        }
    }

}
