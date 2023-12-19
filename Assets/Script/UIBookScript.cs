using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBookScript : MonoBehaviour
{
    public GameObject UIReleventInfoRef;
    public GameObject UIBackToMenuRef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RevealReleventInfoUI()
    {
        UIReleventInfoRef.SetActive(true);
    }

    public void HideRelevantInfoUI()
    {
        UIReleventInfoRef.SetActive(false);
    }
    public void RevealGoingBackToMenu()
    {
        UIBackToMenuRef.SetActive(true);
    }

    public void HideGoingBackToMenu()
    {
        UIBackToMenuRef.SetActive(false);
    }

    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
