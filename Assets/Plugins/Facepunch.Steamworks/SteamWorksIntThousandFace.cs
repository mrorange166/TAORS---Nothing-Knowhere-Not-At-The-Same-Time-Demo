using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksIntThousandFace : MonoBehaviour
{
    [SerializeField] string achievement;

    public void UnlockAchievement()
    {
        var ThousandFace = new Steamworks.Data.Achievement(achievement);
        ThousandFace.Trigger();

        Debug.Log($"achievement {achievement} unlocked");
    }

}
