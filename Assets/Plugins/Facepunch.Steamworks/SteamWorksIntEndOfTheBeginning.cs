using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntEndOfTheBeginning : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Ending = new Steamworks.Data.Achievement(achievement);
        Ending.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
