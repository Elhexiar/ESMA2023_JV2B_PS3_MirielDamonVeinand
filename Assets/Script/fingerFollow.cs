using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonScript : MonoBehaviour
{

    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.acceleration); //Gyroscope du telephone
        //print(Input.touches[0].position); //Position du doigt sur le tel

        //Deplacer l'objet selon la position du doigt
        if (Input.touchCount > 0)
        {
            Camera mainCamera = Camera.main;
            Vector3 tempPosition = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, mainCamera.nearClipPlane + 10);
            transform.position = mainCamera.ScreenToWorldPoint(tempPosition);
        }

    }


    private void OnMouseDown()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("coucou" + collision);
    }

}