using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [System.Serializable]
    public class HasEquipment : SerializableDictionary<string, bool> { }

    public HasEquipment hasEquipment;
    public List<InventoryItem> items;

    [SerializeField]
    private int capacity, slots;
    [SerializeField]
    private EquipmentManager equipmentManager;

    private void Start()
    {
        if (!equipmentManager) equipmentManager = GameObject.FindGameObjectWithTag(EquipmentManager.EQUIPMENT_MANAGER_TAG).GetComponent<EquipmentManager>();
        items = new List<InventoryItem>();
        hasEquipment = new HasEquipment();
    }

    public bool isEquipped(string equipmentID)
    {
        return hasEquipment.ContainsKey(equipmentID);
    }

    public Equipment getEquipment(string equipmentID)
    {
        if (isEquipped(equipmentID))
        {
            foreach (Equipment e in equipmentManager.equipment)
            {
                if (e.id == equipmentID) return e;
            }
        }

        return null;
    }

    public void equip(string equipmentID)
    {
        hasEquipment.Add(equipmentID, true);
    }
    public void unequip(string equipmentID)
    {
        hasEquipment.Add(equipmentID, false);
    }
}


[System.Serializable]
public class Equipment
{
    public string name;
    public Texture2D icon;
    public GameObject itemObject;
    public string id;

    public Equipment(string id)
    {
        this.id = id;
    }
    public Equipment(string id, string name)
    {
        this.id = id;
        this.name = name;
    }
}

[System.Serializable]
public class InventoryItem
{
    public string name;
    public Texture2D icon;
    public GameObject itemObject;
    public int maxQuantity;
}