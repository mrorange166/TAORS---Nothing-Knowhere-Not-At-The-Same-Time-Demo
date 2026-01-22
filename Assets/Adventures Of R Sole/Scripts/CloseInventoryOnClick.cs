using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInventoryOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AC.KickStarter.runtimeInventory.SelectedItem != null && !IsMouseOverUI())
        {
 
        AC.PlayerMenus.GetMenuWithName("Inventory").TurnOff();
        }
    }

    private bool IsMouseOverUI()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
