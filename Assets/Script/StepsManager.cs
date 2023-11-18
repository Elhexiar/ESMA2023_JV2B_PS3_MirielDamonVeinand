using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsManager : MonoBehaviour
{

    public List<GameObject> stepsList = new List<GameObject>();
    [SerializeField] private int CurrentListIndex;
    [SerializeField] public bool nextStepInvoked = false;
    // Start is called before the first frame update
    void Start()
    {
        // Makes Sure that only the first step is active
        foreach (var item in stepsList)
        {
            item.SetActive(false);
        }
        stepsList[0].SetActive(true);

    }

    void NextStep()
    {
        stepsList[CurrentListIndex].SetActive(false);
        CurrentListIndex++;
        if (CurrentListIndex >= stepsList.Count)
        {
            Debug.Log("GG");
        }else
        {
            stepsList[CurrentListIndex].SetActive(true);
        }
        

        

    }

    
    // Update is called once per frame
    void Update()
    {
        if(nextStepInvoked == true) { NextStep(); nextStepInvoked = false; }
    }
}
