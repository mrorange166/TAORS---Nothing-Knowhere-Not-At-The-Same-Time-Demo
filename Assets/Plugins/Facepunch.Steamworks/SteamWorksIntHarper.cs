using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntHarper : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var Harper = new Steamworks.Data.Achievement(achievement);
        Harper.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
