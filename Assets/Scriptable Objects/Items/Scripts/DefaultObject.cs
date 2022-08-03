using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Default Object",menuName = "Inventory System/Items/Default")]
public class DefaultObject : ItemObject
{
    // public int amount;

    //void start(object amount)
    //{
    //    this.amount = ItemObject amount;
    //}
    public void Awake()
    {
        type = ItemType.Default;
        //amount = GameObject;
    }
}
