using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerMovement : MonoBehaviour
{
    public GameObject myDagger;
    public float speed;
    public Library myLibrary;


    // Start is called before the first frame update
    void Start()
    {
        speed = 0.06f;
    }

    // Update is called once per frame
    void Update()
    {
        myDagger.transform.position +=  new Vector3(speed,0,0);
        myDagger.transform.Rotate(0,0,-5.7f, Space.Self);
        if (myDagger.transform.position.x > 10)
        {
            Destroy(myDagger);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(myDagger);
    }
}
