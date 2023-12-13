using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class RthmGameManager : MonoBehaviour
{
    public ZoneManager zoneManager;
    public UnityEvent eventList;

    public PossibleTextures attachedPossibleTexures;
    public GameObject attachedGameObjectToAnimate;

    public List<Cursor> cursorList;
    public int numberOfCursors;
    public Transform cursorSpawnPoint;
    public Transform cursorEndLimit;
    public GameObject cursorPrefab;
    public int index = 0;
    public int timerLimit;
    public int score = 0;
    public int textureIndex = 0;

    public TextMeshProUGUI scoreTextRef;
    // Start is called before the first frame update
    void Start()
    {
        


        for (int i = 0; i < numberOfCursors; i++)
        {

            cursorList.Add(Cursor.Create(i,timerLimit,false,cursorSpawnPoint.position, cursorEndLimit.position,cursorPrefab,this));

        }
        SpawnNextCursor();
        scoreTextRef.text = score.ToString() + "/" + cursorList.Count.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnNextCursor()
    {
        if(index < cursorList.Count)
        {
            cursorList[index].SpawnCursorGameObject();
            index++;
        }
        else
        {
            Debug.Log("GG!!!");
            if (attachedPossibleTexures != null)
            {
                textureIndex = 0;
                attachedGameObjectToAnimate.GetComponent<SpriteRenderer>().sprite = attachedPossibleTexures.possibleTextures[textureIndex];
            }
            zoneManager.ProceedToNextZone();
            gameObject.SetActive(false);
        }


    }

    IEnumerator DoEverySuccesfullHit()
    {

        eventList.Invoke();

        yield return null;
    }

    public void IncreaseScore()
    {
        if(attachedPossibleTexures!=null)
        {
            textureIndex++;
            attachedGameObjectToAnimate.GetComponent<SpriteRenderer>().sprite = attachedPossibleTexures.possibleTextures[textureIndex];
        }
        
        score++;
        scoreTextRef.text = score.ToString() + "/" + cursorList.Count.ToString();
    }
}
