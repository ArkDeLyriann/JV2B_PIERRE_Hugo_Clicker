using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 200;
    public GameObject myEntity;
    public Library myLibrary;
    public EnemyManager myEnemyManager;
    private int damage;
    public ParticleSystem mySystem;

    public List<Elements> weaknesses;


    // Start is called before the first frame update
    void Start()
    {
        myLibrary = FindObjectOfType<Library>();
        myEnemyManager = FindObjectOfType<EnemyManager>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        var dagger = collision.gameObject.GetComponent<Knife>().Dagger;
        if (dagger != null)
        {
            TakeDamage(dagger);
        }

    }

    public void Death()
    {

        //System
        myLibrary.money += 100;
        myLibrary.ennemyAlive = false;

        //Respawn
        myEnemyManager.Process();

        //Feedback
        Destroy(myEntity);
    }
    public void TakeDamage(Dagger dagger)
    {
        //Calcul total damage
        var totalDamage = dagger.damage;
        if (weaknesses.Contains(dagger.element))
        {
            totalDamage *= 2;
        }

        //Apply
        health -= totalDamage;
        if (health <= 0)
        {
            Death();
        }

        //Feedbacks 
        mySystem.Play();

    }
}
