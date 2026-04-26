using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntPadLock : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Padlock = new Steamworks.Data.Achievement(achievement);
        Padlock.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
