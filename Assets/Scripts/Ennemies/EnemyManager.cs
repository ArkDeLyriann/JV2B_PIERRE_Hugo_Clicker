using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<GameObject> allCaveCreatures;
    public List<GameObject> allRats;
    public Library myLibrary;
    public GameObject activeEnemy;
    public World world;
    public bool alive;
    private int ennemyKilled = 0;
    public int difficultyLevel = 0;
    private int threshold = 5;

    private void Awake()
    {
        myLibrary = FindObjectOfType<Library>();
    }
    // Start is called before the first frame update
    void Start()
    {

        world = myLibrary.activeWorld;
        activeEnemy = world.Ennemies[0];
        

        Spawn();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ennemyKilled > threshold)
        {
            difficultyLevel += 1;
            ennemyKilled = 0;
            //threshold += 5;
        }
        if (difficultyLevel > world.Ennemies.Count)
        {
            difficultyLevel = 0;
        }
    }

    public void Spawn()
    {
        activeEnemy = myLibrary.activeWorld.Ennemies[difficultyLevel];

        Instantiate(activeEnemy, new Vector3 (7,0,0),Quaternion.identity);
        
    }

    public void Process()
    {
        ennemyKilled += 1;
        activeEnemy = myLibrary.activeWorld.Ennemies[difficultyLevel];
        StartCoroutine(waiter());
    }
    
    public IEnumerator waiter()
    {
        
        yield return new WaitForSeconds(2);

        Spawn();

    }

}
