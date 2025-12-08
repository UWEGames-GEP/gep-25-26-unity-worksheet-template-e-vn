using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefreshInventory : MonoBehaviour
{
    public InventoryScript inventory;
    public List<GameObject> inventoryUIButtons = new List<GameObject>();
    public GameObject InventoryPannel;


    public void OnInventoryUIButtons(int i)
    {
        inventory.RemoveItem(i);
        InventoryRefresh();
    }
    private void OnEnable()
    {
        inventoryUIButtons.Clear();
        CollectButtons(InventoryPannel.transform, inventoryUIButtons);
        InventoryRefresh();
    }

    void InventoryRefresh()
    {
        Debug.Log("Refresh Inventory UI");

        foreach (GameObject button in inventoryUIButtons)
        {
            button.SetActive(false);
        }

        Debug.Log(inventory.items.Count);
        for (int i = 0; i < inventory.items.Count; i++)
        {
            Debug.Log(inventoryUIButtons.Count);

            if (i < inventoryUIButtons.Count)
            {
                var uiButtons = inventoryUIButtons[i].GetComponent<InventoryUIButtons>();
                var item = inventory.items[i];

                uiButtons.gameObject.SetActive(true);
                uiButtons.SetButton(item);

            }

        }

    }

    public void CollectButtons(Transform pannel, List<GameObject> list)
    {
        foreach (Transform button in pannel)
        {
            if (button.gameObject.tag == "Button")
            {
                list.Add(button.gameObject);
            }
        }


    }







}
