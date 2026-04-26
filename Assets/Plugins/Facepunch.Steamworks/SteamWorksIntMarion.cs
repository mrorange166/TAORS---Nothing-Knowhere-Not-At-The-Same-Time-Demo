using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntMarion : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Marion = new Steamworks.Data.Achievement(achievement);
        Marion.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
