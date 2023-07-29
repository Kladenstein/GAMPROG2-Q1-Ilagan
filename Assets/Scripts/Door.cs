using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    bool slide = false;

    // Update is called once per frame
    void Update()
    {
        if (slide)
            transform.localPosition += Vector3.forward * Time.deltaTime;
    }

    public override void Interact()
    {
        //check if all items are collected.
        if (InventoryManager.Instance.FindInventoryItem("Key"))
        {
            id = "UNLOCKED!";
            slide = true;
        }
        else
            id = "LOCKED!";
    }
}
