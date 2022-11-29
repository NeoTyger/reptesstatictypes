using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private string itemName;
    private int id = 0;
    private string description;

    public static int itemsCreats = 0;


    public Item(string itemName, string description)
    {
            
        //Initialize things here
        this.itemName = itemName;
        this.description = description;
        itemsCreats++;
        id = itemsCreats;
    }

    public Item()
    {
        itemsCreats++;
        id = itemsCreats;
    }

    public string GetItemName()
    {
        return itemName;
    }
    
    public int GetId()
    {
        return id;
    }

    public virtual void MyTreat()
    {
        Debug.Log("Som un item general, no tenc característica especial");
    }
}
