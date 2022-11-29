using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemList : MonoBehaviour
{

    private List<Item> itemList = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        itemList.Add(new Item("Uno", "Joc de cartes"));
        itemList.Add(new Item("Monopoly", "Joc de taules"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            itemList.Add(new Item());
            Debug.Log("Item afegit");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            itemList.RemoveAt(0);
            Debug.Log("Primer item eliminat");
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Items totals " + Item.itemsCreats);
        }
    }
}
