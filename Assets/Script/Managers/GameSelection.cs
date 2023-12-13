using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelection : MonoBehaviour
{
    // Start is called before the first frame update

    public void StartSlicingGame()
    {
        Debug.Log("SliceING");
        SceneManager.LoadScene("Slice");
    }

    public void StartGalette()
    {
        SceneManager.LoadScene("Galettage");
    }

    public void StartRecipeSelectionMenue()
    {
        SceneManager.LoadScene("RecipeSelectionMenue");
    }
}
