using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : ScriptableObject
{
    RthmGameManager managerRef;
    GameObject prefab;
    [SerializeField]
    int index;
    [SerializeField]
    bool active;
    [SerializeField]
    public bool succesfullyHit = false, failed = false;
    [SerializeField]
    Vector3 spawn, endLimit;
    [SerializeField]
    GameObject linkedGameObject;
    CursorBehaviour linkedCursorBehaviour;

    [SerializeField]
    int cursorTimerLimit = 1000;

    public static Cursor Create(int index,int timerLimit ,bool activeStatus, Vector3 newSpawn,Vector3 endLimit, GameObject prefab, RthmGameManager rthmGameManagerRef)
    {
        Cursor newCursor = CreateInstance<Cursor>();

        newCursor.managerRef = rthmGameManagerRef;

        newCursor.prefab = prefab;
        newCursor.index = index;
        newCursor.active = activeStatus;
        newCursor.spawn = newSpawn;
        newCursor.endLimit = endLimit;
        newCursor.cursorTimerLimit = timerLimit;



        return newCursor;


    }
    


    // SETTERS
    public void SetIndex(int newIndex)
    {
        index = newIndex;
    }

    public void SetActiveStatus(bool newStatus)
    {
        active = newStatus;
    }


    // GETTERS

    public int GetIndex()
    {
        return index;
    }

    public bool GetActiveStatus()
    {
        return active;
    }

    public CursorBehaviour getCursorBehaviourRef()
    {
        return linkedCursorBehaviour;
    }

    public GameObject getCursorGameObject()
    {
        return linkedGameObject;
    }



    public GameObject SpawnCursorGameObject()
    {
        active = true;
        linkedGameObject = Instantiate(prefab, spawn, Quaternion.identity);
        linkedCursorBehaviour = linkedGameObject.GetComponent<CursorBehaviour>();
        linkedCursorBehaviour.endLimit = endLimit;
        linkedCursorBehaviour.spawn = spawn;
        linkedCursorBehaviour.parentCursor = this;
        linkedCursorBehaviour.timerLimit = cursorTimerLimit;

        return linkedGameObject;
    }

    public void cursorHitLimit()
    {
        Destroy(linkedGameObject);
        active = false;

        managerRef.SpawnNextCursor();



    }

    


}
