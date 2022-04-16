using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Nuevo Item", menuName = "My Scriptable OB/Item")]
public class Item : ScriptableObject
{
    public float cost;

    public new string name;

    public string description;

    public Sprite sprt_image;

    public GameObject Ob_item;

    public int quantity;
    public enum Type
    {
        FOOD,
        ANT,
        COSUMABLE

    }

    public Type type;




}
