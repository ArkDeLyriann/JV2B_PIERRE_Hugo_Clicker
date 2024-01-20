using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerThrower : MonoBehaviour
{
    public GameObject thrownDagger;
    public Library myLibrary;
    // Start is called before the first frame update
    void Start()
    {
        myLibrary = FindObjectOfType<Library>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Throw()
    {
        thrownDagger = myLibrary.activeDagger;
        Instantiate(thrownDagger, new Vector3(-7,0,0), Quaternion.identity);
    }
}
