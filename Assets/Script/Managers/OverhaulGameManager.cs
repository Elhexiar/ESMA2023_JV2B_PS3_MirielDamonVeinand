using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverhaulGameManager : MonoBehaviour
{

    public static OverhaulGameManager Instance;

    public List<RecipeData> recipeDataList;
    public List<GameObject> pinLists;

    // Start is called before the first frame update
    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableOmelettePin()
    {
        pinLists[1].GetComponent<Button>().interactable = true;
    }
}
