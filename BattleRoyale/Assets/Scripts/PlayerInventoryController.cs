using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (InventoryController))]
public class PlayerInventoryController : MonoBehaviour
{
    private InventoryController playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        playerInventory = GetComponent<InventoryController>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
