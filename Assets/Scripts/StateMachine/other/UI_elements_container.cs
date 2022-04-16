using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class UI_elements_container : MonoBehaviour
{
    public TextMeshProUGUI txt_food;
    public TextMeshProUGUI txt_amountAnt;
    public Button btn_BuyAnt;

    internal void UpdateTextFood(int food)
    {
        txt_food.text = "Food: " + food.ToString().PadLeft(5, '0');
    }
    internal void UpdateTextAnt(int newAntAmount)
    {
        txt_amountAnt.text = "Amount ant: " + newAntAmount.ToString().PadLeft(5, '0');
    }
}
