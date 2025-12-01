using UnityEngine;
using System.Collections.Generic;

public class InventoryScript : MonoBehaviour
{
    public List<ItemScript> items = new List<ItemScript>();

    public GameManagerAdd gameManager;
    public Transform ItemTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Find The Game Manager and reference it
        gameManager = FindAnyObjectByType<GameManagerAdd>();

        //Find Items transform and reference it
        Transform ItemTransform = GameObject.Find("Items").transform;

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

    public void AddItem(ItemScript item)
    {
        items.Add(item);
    }
    public void RemoveItem(ItemScript item)
    {
        items.Remove(item);
    }

    public void RemoveItem()
    {
        //check that we can remove item from inventory
        ItemScript item = items[0];

        //Get properties for where we want to spawn
        Vector3 currentPosition = transform.position;
        Vector3 forward = transform.forward;

        Vector3 newPosition = currentPosition + forward;
        newPosition += new Vector3(0, 1, 0);

        Quaternion currentRotation = transform.rotation;
        Quaternion newRotation = currentRotation * Quaternion.Euler(0, 0, 180);

        //Instantiate copy of held item
        GameObject newItem = Instantiate(item.gameObject, newPosition, newRotation, ItemTransform);
        newItem.SetActive(true);

        //Clean up exisiting item
        items.Remove(item);
        Destroy(item.gameObject);

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Get Item componenet from hit object if it exisits
        ItemScript collisionItem = hit.gameObject.GetComponent<ItemScript>();

        //check if object has Item componenet
        if (collisionItem != null)
        {
            //Add the item to data structure
            items.Add(collisionItem);

            //Destory game object that item component 
            //Destroy(collisionItem.gameObject);

            collisionItem.gameObject.SetActive(false);
        }
        
    }
}
