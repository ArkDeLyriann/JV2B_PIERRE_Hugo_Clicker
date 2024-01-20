using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingButtons : MonoBehaviour
{
    public Library myLibrary;
    private int money;
    private int autoPrice;
    private int daggersPrice = 500;
    public Button equipButton;
    public Button self;


    void Start()
    {
        myLibrary = FindObjectOfType<Library>();
        
    }

    void Update()
    {
        money = myLibrary.money;
        autoPrice = 100 + myLibrary.autoClickLevel * 100;
    }

    public void BuyAutoClick()
    {
        if (money >= autoPrice) 
        {
            money -= autoPrice;
            myLibrary.money = money;
            myLibrary.autoClickLevel += 1;

        }
    }

    public void BuyMolten()
    {
        if(money >= daggersPrice) 
        {
            myLibrary.money -= daggersPrice;
            myLibrary.moltenUnlocked = true;
            equipButton.interactable = true;
            self.interactable = false;
        }
    }

    public void BuyDruid() 
    {
        if (money >= daggersPrice)
        {
            myLibrary.money -= daggersPrice;
            myLibrary.vineyardUnlocked = true;
            equipButton.interactable = true;
            self.interactable = false;
        }
    }

    public void BuyDredge()
    {
        if (money >= daggersPrice)
        {
            myLibrary.money -= daggersPrice;
            myLibrary.dredgeUnlocked = true;
            equipButton.interactable = true;
            self.interactable = false;

        }
    }

    public void BuyStarry()
    {
        if (money >= daggersPrice*2)
        {
            myLibrary.money -= daggersPrice * 2;
            myLibrary.starryUnlocked = true;
            equipButton.interactable = true;
            self.interactable = false;
        }
    }
}
