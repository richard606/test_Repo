using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_ManagerPurchase : MonoBehaviour
{

    public void BuyItem(Item_display item, int foodAvailable)
    {
        if (item.info.cost <= foodAvailable)
        {
            GameManager.instance.RemoveFood((int)item.info.cost);
            GameManager.instance.AddItem(item);
        }
        else
        {
            Message.instance.ShowMessageDialog("¡No tienes suficiente comida para esta compra!");
        }


    }
}
