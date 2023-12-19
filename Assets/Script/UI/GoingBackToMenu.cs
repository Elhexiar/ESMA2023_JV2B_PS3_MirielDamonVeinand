using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoingBackToMenu : MonoBehaviour
{
    public GameObject goingBackToMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGoingBackToMenu()
    {
        goingBackToMenuUI.SetActive(true);
    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
