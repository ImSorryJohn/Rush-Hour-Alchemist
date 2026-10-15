using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CraftingManager : MonoBehaviour
{
    private Item currentItem;
    public Image customCursor;
    public Slot[] craftingSlots;
    public List<Item> itemList;
    public string[] recipies;
    public Item[] recipeItems;
    public Slot resultSlot;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(currentItem != null)
            {
                customCursor.gameObject.SetActive(false);
                Slot nearestSlot = null;
                float minDistance = float.MaxValue;
                foreach(Slot slot in craftingSlots)
                {
                    float distance = Vector2.Distance(Input.mousePosition, slot.transform.position);
                    if(distance < minDistance)
                    {
                        minDistance = distance;
                        nearestSlot = slot;
                    }
                }
                nearestSlot.gameObject.SetActive(true);
                nearestSlot.GetComponent<Image>().sprite = currentItem.GetComponent<Image>().sprite;
                nearestSlot.item = currentItem;
                itemList[nearestSlot.index] = currentItem;
                currentItem = null;

                CheckForCreatedRecipe();
            }
        }
    }

    void CheckForCreatedRecipe()
    {
        resultSlot.gameObject.SetActive(false);
        resultSlot.item = null;

        string currentRecipeString = "";
        foreach(Item item in itemList)
        {
            if(item != null)
            {
                currentRecipeString += item.itemName + ",";
            }
            else
            {
                currentRecipeString += "null,";
            }
        }

        for(int i = 0; i < recipies.Length; i++)
        {
            if(recipies[i] == currentRecipeString)
            {
                resultSlot.gameObject.SetActive(true);
                resultSlot.GetComponent<Image>().sprite = recipeItems[i].GetComponent<Image>().sprite;
                resultSlot.item = recipeItems[i];
                break;
            }
        }
    }

    public void OnClickSlot(Slot slot)
    {
        slot.item = null;
        itemList[slot.index] = null;
        slot.gameObject.SetActive(false);
        CheckForCreatedRecipe();
    }

    public void OnMouseDownItem(Item item)
    {
        if(currentItem == null){
            currentItem = item;
            customCursor.gameObject.SetActive(true);
            customCursor.sprite = currentItem.GetComponent<Image>().sprite;
        }
    }
}

