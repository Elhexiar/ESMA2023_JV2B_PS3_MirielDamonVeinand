using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinManager : MonoBehaviour
{
    public OverhaulGameManager gameManager;
    public List<GameObject> pins;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = (OverhaulGameManager)FindAnyObjectByType(typeof(OverhaulGameManager));
        for (int i = 0; i < gameManager.RecipeButtonsState.Count; i++)
        {
            if (gameManager.RecipeButtonsState[i] == true)
            {
                Debug.Log("PIN" + i);
                pins[i].GetComponent<Button>().interactable = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
