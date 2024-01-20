using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Library : MonoBehaviour
{
    public GameObject[] allDaggers;
    public GameObject activeDagger;
    public DaggerThrower daggerThrower;
    public int equipedDagger;
    private GameObject target;
    public bool ennemyAlive = false;
    public int autoClickLevel = 0;
    public int money;
    public float delay = 10;
    public float throwTimer;
    public bool moltenUnlocked=false;
    public bool starryUnlocked = false;
    public bool vineyardUnlocked = false;
    public bool dredgeUnlocked = false;
    public List<World> worlds;
    public World activeWorld;

    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI worldText;

    public Button[] equipButtons;
    public Button[] buyButtons;

    private void Awake()
    {
        activeWorld = worlds[0];
    }
    // Start is called before the first frame update
    void Start()
    {
        equipedDagger = 0;
        activeDagger = allDaggers[equipedDagger];
        for (int i = 0; i < equipButtons.Length; i++) 
        {
            equipButtons[i].interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        throwTimer += Time.deltaTime;
        delay = 10 - 0.5f * autoClickLevel;
        activeDagger = allDaggers[equipedDagger];

        if (autoClickLevel > 0)
        {
            if(throwTimer> delay)
            {
                throwTimer = 0;
                daggerThrower.Throw();
            }
            
        }

        moneyText.text = money.ToString("") + "  Gold";

        worldText.text = activeWorld.name;
        
    }

   

}
