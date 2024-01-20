using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipButtons : MonoBehaviour
{
    public Library myLibrary;

    private void Start()
    {
        myLibrary = FindObjectOfType<Library>();
    }

    public void EquipBase()
    {
        myLibrary.equipedDagger = 0;
    }
    public void EquipMolten()
    {
        myLibrary.equipedDagger = 1;
    }
    public void EquipDredge()
    {
        myLibrary.equipedDagger = 2;
    }

    public void EquipVineyard()
    {
        myLibrary.equipedDagger = 3;
    }

    public void EquipStarry()
    {
        myLibrary.equipedDagger = 4;
    }

    
}
