using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntRepair : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Repair = new Steamworks.Data.Achievement(achievement);
        Repair.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
