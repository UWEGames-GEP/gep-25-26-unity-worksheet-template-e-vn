using UnityEngine;
using Systems.Collections.Generic;

public class InventoryScript : MonoBehaviour
{
  
    public List<string> items = new List<string>();
    items.Add(itemName);
    items.Remove(itemName);

    FindAnyObjectByType<T>

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Find The Game Manager and reference it
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        if (input.GetKeyDown(KeyCode.Alpha1))
        {
            AddItemToInventory("Generic Item");
        }
        if (input.GetKeyDown(KeyCode.Alpha1))
        {
            RemoveItemFromInventory("Generic Item");
        }
    }
}
