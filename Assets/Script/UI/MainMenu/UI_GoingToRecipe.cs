using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_GoingToRecipe : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToRecipe(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void HideGoingToRecipeMenu()
    {
        gameObject.SetActive(false);
    }


}
