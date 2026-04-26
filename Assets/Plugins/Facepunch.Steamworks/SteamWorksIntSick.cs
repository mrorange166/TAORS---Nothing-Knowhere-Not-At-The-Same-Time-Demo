using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntSick : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Sick = new Steamworks.Data.Achievement(achievement);
        Sick.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
