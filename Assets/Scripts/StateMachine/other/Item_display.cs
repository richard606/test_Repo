using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Item_display : MonoBehaviour

{

    public Item info;
    [SerializeField] TextMeshProUGUI txt_nameItem;
    [SerializeField] TextMeshProUGUI txt_costItem;
    [SerializeField] Image img_item;



    void Start()
    {
        txt_nameItem.text = "Buy:\n" + info.name;
        txt_costItem.text = "Cost: " + info.cost.ToString();
        img_item.sprite = info.sprt_image;

    }


}
