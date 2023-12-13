using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RthmHitzone : MonoBehaviour, ITouchable
{
    public RthmGameManager rthmGameManagerRef;

    public float lowerEndAcceptableHit = 0.40f;
    public float upperEndAcceptableHit = 0.60f;

    
    
    public void OnTouchedDown(Vector3 touchPosition)
    {
        
        foreach (var cursor in rthmGameManagerRef.cursorList)
        {
            if (cursor.GetActiveStatus())
            {
                float currentCursorProgress = cursor.getCursorBehaviourRef().currentRelativePosition;
                Debug.Log("CurrentPosition =" + currentCursorProgress);
                if (currentCursorProgress >= lowerEndAcceptableHit && currentCursorProgress <= upperEndAcceptableHit)
                {
                    if(cursor.failed == false)
                    {
                        rthmGameManagerRef.IncreaseScore();
                        cursor.succesfullyHit = true;
                        Debug.Log("HIT");
                        cursor.getCursorGameObject().GetComponent<SpriteRenderer>().color = Color.green;
                    }
                    
                }
                else
                {
                    if(cursor.succesfullyHit == false)
                    {
                        cursor.failed = true;
                        cursor.getCursorGameObject().GetComponent<SpriteRenderer>().color = Color.red;
                    }
                    
                }
            }
            

        }

    }

    public void OnTouchedStay(Vector3 touchPosition)
    {
        
    }

    public void OnTouchedUp()
    {
        
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
