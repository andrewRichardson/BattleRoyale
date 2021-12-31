using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    public const string EQUIPMENT_MANAGER_TAG = "Equipment_Manager";

    [SerializeField]
    public static readonly string[] equipmentIDs = {
        "GrappleHook",
        "StrafePack",
        "GripRig"
    };

    [SerializeField]
    public Equipment[] equipment = { new Equipment(equipmentIDs[0], "Grapple Hook"), new Equipment(equipmentIDs[1], "Strafe Pack"), new Equipment(equipmentIDs[2], "Grip Rig") };

    // Start is called before the first frame update
    void Start()
    {
        tag = EQUIPMENT_MANAGER_TAG;
    }

    // Update is called once per frame
    void Update()
    {

    }

}
