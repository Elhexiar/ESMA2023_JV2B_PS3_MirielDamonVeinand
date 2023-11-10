using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MonScript : MonoBehaviour
{
    [SerializeField]
    private Vector3 tempPosition;
    [SerializeField]
    private Vector3 delta;
    public Vector3 position;
    public Quaternion newRotation;
    public float normalizedRot;
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
            tempPosition = new Vector3(Input.touches[0].position.x, Input.touches[0].position.y, mainCamera.nearClipPlane + 10-0.3f);
            delta = Input.touches[0].deltaPosition;
            delta.Normalize();
            
            normalizedRot = 180+Mathf.Atan2(delta.y, delta.x) * 180 / 3.14f;

            transform.rotation = Quaternion.Euler(0,0, normalizedRot);
            
            
            //transform.rotation.SetEulerRotation(0, 0, normalizedRot);
            //transform.rotation.Set(0, 0, normalizedRot);

            transform.position = mainCamera.ScreenToWorldPoint(tempPosition);
        }

    }



    

}