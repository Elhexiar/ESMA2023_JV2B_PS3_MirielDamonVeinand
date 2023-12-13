using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingZone : MonoBehaviour
{
    public ZoneManager zoneManager;
    public float waitingTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitBeforeNextZone(waitingTime)); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitBeforeNextZone(float amount)
    {
        Debug.Log("Je commence a attendre "+ amount.ToString());
        yield return new WaitForSeconds(amount);
        Debug.Log("YO j'ai attendu suffisemment de temps");
        zoneManager.ProceedToNextZone();
        gameObject.SetActive(false);
    }
}
