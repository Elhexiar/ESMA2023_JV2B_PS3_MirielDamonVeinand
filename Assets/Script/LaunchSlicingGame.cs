using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class LaunchSlicingGame : MonoBehaviour
{

    public void StartSlicingGame()
    {
        SceneManager.LoadScene("Slice");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
