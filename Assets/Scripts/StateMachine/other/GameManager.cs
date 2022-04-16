using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] UI_elements_container uI_Elements;
    [SerializeField] Scr_ManagerPurchase managerPurchase;
    [SerializeField] Scr_ManagerInventory managerInventory;
    [SerializeField] Scr_ManagerFood managerFood;
    [SerializeField] Scr_ManagerData managerData;
    public static GameManager instance;
    [SerializeField] Transform homeTF;

    [SerializeField] Item ant;
    private void Awake()
    {
        instance = this;
        AssignEventButtons();

        AddMoreFood(300);
    }

    private void Start()
    {
        Application.targetFrameRate = 30;
    }




    private void AssignEventButtons()
    {
        uI_Elements.btn_BuyAnt.onClick.AddListener
        (
            () => managerPurchase.BuyItem(
            uI_Elements.btn_BuyAnt.gameObject.GetComponentInParent<Item_display>(),
            managerInventory.Food)
        );
    }

    public void AddMoreFood(int cantFood)
    {
        managerInventory.AddMoreFood(cantFood);
        uI_Elements.UpdateTextFood(managerInventory.Food);
    }

    public void RemoveFood(int food)
    {
        managerInventory.RemoveMoreFood(food);
        uI_Elements.UpdateTextFood(managerInventory.Food);
    }

    public void RemoveFoodInstance(Food food)
    {
        managerFood.RemoveFood(food);

    }


    public void AddMoreAnt(Item Ant)
    {
        managerInventory.AddMoreAnt(Ant, homeTF);
        uI_Elements.UpdateTextAnt(managerInventory.AmountAnt);
    }



    private void AddMoreConsumable(int v)
    {
        throw new NotImplementedException();
    }

    internal void AddItem(Item_display item)
    {
        switch (item.info.type)
        {

            case Item.Type.ANT:
                AddMoreAnt(item.info);
                break;
            case Item.Type.FOOD:
                AddMoreFood(100);
                break;
            case Item.Type.COSUMABLE:
                AddMoreConsumable(100);
                break;
        }

    }

    public int GetAmoundAnt()
    {
        return managerInventory.AmountAnt;
    }
}
