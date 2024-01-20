using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldChangingButtons : MonoBehaviour
{
    public Library myLibrary;
    public EnemyManager myManager;
    public Enemy myEnemy;

    public void Update()
    {
        myEnemy = FindObjectOfType<Enemy>();
    }

    public void GoToCave()
    {
        myLibrary.activeWorld = myLibrary.worlds[0];
        myManager.difficultyLevel = 0;
        Destroy(myEnemy);
    }
    
    public void GoToRats()
    {
        myLibrary.activeWorld = myLibrary.worlds[1];
        myManager.difficultyLevel = 0;
        Destroy(myEnemy);
    }

    
}
