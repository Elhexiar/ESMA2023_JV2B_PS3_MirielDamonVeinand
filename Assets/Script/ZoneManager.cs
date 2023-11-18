using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class ZoneManager : MonoBehaviour
{

    public List<GameObject> zonesList = new List<GameObject>();
    [SerializeField] private int CurrentZoneIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.touchCount > 0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            Debug.Log("Touch" + Input.touches[0].position.ToString()); 
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log("ray hit" + hit.point.ToString());
                if (hit.collider.gameObject == zonesList[CurrentZoneIndex]) {

                    Debug.Log("SUCCES");
                    zonesList[CurrentZoneIndex].GetComponent<SpriteRenderer>().color = Color.white;
                    CurrentZoneIndex++;
                }

            }
        }
        */

        if(Input.touchCount > 0)
        {
            Camera myCamera = Camera.main;
            Vector3 screenTouchPos = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, myCamera.farClipPlane);
            Vector3 touchPosWorld = myCamera.ScreenToWorldPoint(screenTouchPos);
            Debug.DrawLine(myCamera.transform.position, touchPosWorld, Color.red);
            if(Physics.Raycast(myCamera.transform.position, touchPosWorld - myCamera.transform.position, out var info))
            {
                //Debug.Log("yo");
                if (info.collider.gameObject == zonesList[CurrentZoneIndex])
                {

                    Debug.Log("SUCCES");
                    zonesList[CurrentZoneIndex].GetComponent<SpriteRenderer>().color = Color.white;
                    CurrentZoneIndex++;
                    zonesList[CurrentZoneIndex].SetActive(true);
                }
            }


        }
        
    }
}
