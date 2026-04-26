using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntAllItemsFound : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Items = new Steamworks.Data.Achievement(achievement);
        Items.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
