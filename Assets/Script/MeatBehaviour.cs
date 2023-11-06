using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatBehaviour : MonoBehaviour
{
    public GameObject leftSlice;
    public GameObject rightSlice;
    public SpriteRenderer sprite;
    public bool sliced = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        /*
        leftSlice.SetActive(true);
        leftSlice.GetComponent<Rigidbody2D>().AddForce( new Vector3 (30, 0, 0) );
        leftSlice.GetComponent<Rigidbody2D>().angularVelocity = -30;
        rightSlice.SetActive(true);
        rightSlice.GetComponent<Rigidbody2D>().AddForce(new Vector3(-30, 0, 0));
        rightSlice.GetComponent<Rigidbody2D>().angularVelocity = 30;

        sliced = true;
        sprite.enabled = false;
        */

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("coucou" + collision);
    }

}
