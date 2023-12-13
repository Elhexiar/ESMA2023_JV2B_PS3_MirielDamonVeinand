using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverhaulGameManager : MonoBehaviour
{

    public static OverhaulGameManager Instance;

    public List<RecipeData> recipeDataList;


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
}
