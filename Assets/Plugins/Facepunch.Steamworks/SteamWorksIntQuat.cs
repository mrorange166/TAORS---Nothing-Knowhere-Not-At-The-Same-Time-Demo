using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntQuat : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var quattro = new Steamworks.Data.Achievement(achievement);
        quattro.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
