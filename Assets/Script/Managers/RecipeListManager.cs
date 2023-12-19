using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeListManager : MonoBehaviour
{
    public OverhaulGameManager myOverhaulGameManager;
    public List<GameObject> recipeButtonList;
    // Start is called before the first frame update
    void Start()
    {
        myOverhaulGameManager = (OverhaulGameManager)FindAnyObjectByType(typeof(OverhaulGameManager));

        for (int i = 0; i < myOverhaulGameManager.RecipeButtonsState.Count; i++)
        {
            if (myOverhaulGameManager.RecipeButtonsState[i] == true)
            {
                recipeButtonList[i].GetComponent<Button>().interactable = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
