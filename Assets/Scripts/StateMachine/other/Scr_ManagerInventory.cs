using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scr_ManagerInventory : MonoBehaviour
{
    private int food = 0;
    private int amountAnt;

    public List<Item> lst_items = new List<Item>();

    public int Food { get => food; set => food = value; }
    public int AmountAnt { get => amountAnt; set => amountAnt = value; }

    public void AddMoreFood(int cantfood)
    {
        Food += cantfood;
    }

    public void RemoveMoreFood(int food)
    {
        Food -= food;


    }

    public void AddMoreAnt(Item ant, Transform posParent)
    {
        Instantiate(ant.Ob_item, posParent.position, Quaternion.identity);
        lst_items.Add(ant);
        AmountAnt += ant.quantity;

    }
}
