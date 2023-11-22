using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PossibleEvents : MonoBehaviour
{
    public Animator eggAnimator;
    public Animator currentAnimator;
    public TextMeshProUGUI instructionsVariable;
    public GameObject currentHeldObject;
    public Vector3 nextPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TurnWhite(GameObject zone)
    {
        zone.GetComponent<SpriteRenderer>().color = Color.white;
        if (zone.GetComponent<PathZoneInfo>().hideAfterTouch)
        {
            zone.SetActive(false);
        }
 
    }

    public void ChangeInstructions(string instructions)
    {
        instructionsVariable.text = instructions;
    }

    public void InstantiatePrefabToDrag(GameObject prefab)
    {
        currentHeldObject = Instantiate(prefab);
    }

    

    public void destroyGameObject(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    public void destroyObjectDragged()
    {
        Destroy(currentHeldObject);
    }

    public void EggAppears()
    {
        Debug.Log("The egg appears");
        eggAnimator.SetTrigger("EggPickUp");
    }

    public void SetAnimator(Animator animator)
    {
        currentAnimator = animator;
    }
    public void SetTrigger(string trigger)
    {
        currentAnimator.SetTrigger(trigger);

    }

    public void EggCracks()
    {
        Debug.Log("EggCracks");
        eggAnimator.SetTrigger("EggBreak");
    }

    public void EggSplits()
    {
        Debug.Log("EggSplits");
        eggAnimator.SetTrigger("EggSplit");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
