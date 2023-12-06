using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScreenManager : MonoBehaviour
{
    public FollowScreen[] followScreens;
    public ZoneManager zoneManager;

    // Start is called before the first frame update
    void Start()
    {
        followScreens = FindObjectsByType<FollowScreen>(FindObjectsSortMode.InstanceID);

    }


    public void SetFSActives(bool active)
    {
        followScreens = FindObjectsByType<FollowScreen>(FindObjectsSortMode.InstanceID);
        if (zoneManager.CurrentZoneIndex < zoneManager.zonesList.Count)
        {
            zoneManager.zonesList[zoneManager.CurrentZoneIndex].GetComponent<PathZoneInfo>().touchable = active;
        }
        
        foreach (var f in followScreens)
        {
            Debug.Log("desactivation");
            f.active = active;
        }
    }

}
