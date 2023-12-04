using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RecipeSelectionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartSlicingGame()
    {
        SceneManager.LoadScene("Slice");
    }

    public void StartGalette()
    {
        SceneManager.LoadScene("Galettage");
    }

    
}
