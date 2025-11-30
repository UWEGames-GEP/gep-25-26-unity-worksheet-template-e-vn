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
      // if (Input.GetKeyDown(KeyCode.T))
      // {
      //    AddItem("Generic Item");
      // }
      // if (Input.GetKeyDown(KeyCode.Y))
      // {
      //    RemoveItem("Generic Item");
      //  }
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }
    public void RemoveItem(string item)
    {
        items.Remove(item);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Get Item componenet from hit object if it exisits
        ItemScript collisionItem = hit.gameObject.GetComponent<ItemScript>();

        //check if object has Item componenet
        if (collisionItem != null)
        {
            //Add the item to data structure
            items.Add(collisionItem.itemName);
            //Destory game object that item component 
            Destroy(collisionItem.gameObject);
        }
        
        
    }
}
