using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StepsManager : MonoBehaviour
{

    public List<GameObject> stepsList = new List<GameObject>();
    [SerializeField] private int CurrentListIndex;
    //[SerializeField] public bool nextStepInvoked = false;
    public bool enablesNextRecipe = false;

    public GameObject victoryUI;

    public OverhaulGameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = (OverhaulGameManager)FindAnyObjectByType(typeof(OverhaulGameManager));
        // Makes Sure that only the first step is active
        foreach (var item in stepsList)
        {
            item.SetActive(false);
        }
        stepsList[0].SetActive(true);

    }

    public void NextStep()
    {

        if (CurrentListIndex < stepsList.Count)
        {
            stepsList[CurrentListIndex].SetActive(false);
        }
        CurrentListIndex++;
        if (CurrentListIndex >= stepsList.Count)
        {
            victoryUI.SetActive(true);
            if (enablesNextRecipe)
            {
                gameManager.EnableNewRecipe();
            }

            //Debug.Log("C'est LA FIN");
        }else
        {
            
            
            //Debug.Log("Next Step");
            stepsList[CurrentListIndex].SetActive(true);
        }
        

        

    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
