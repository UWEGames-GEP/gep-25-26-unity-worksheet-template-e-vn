using UnityEngine;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour
{
    public List<string> items = new List<string>();
    public GameManagerAdd gameManager;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Find The Game Manager and reference it
        gameManager = FindAnyObjectByType<GameManagerAdd>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {
            AddItem("Generic Item");
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            RemoveItem("Generic Item");
        }
    }

    public void AddItem(string item)
    {
        items.Add(item);  
    }
    public void RemoveItem(string item)
    {
        items.Remove(item);
    }

}
