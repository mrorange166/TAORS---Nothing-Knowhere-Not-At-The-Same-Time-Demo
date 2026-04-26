using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntTendril : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Tendril = new Steamworks.Data.Achievement(achievement);
        Tendril.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
