using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBookScript : MonoBehaviour
{
    public GameObject UIReleventInfoRef;
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
}
