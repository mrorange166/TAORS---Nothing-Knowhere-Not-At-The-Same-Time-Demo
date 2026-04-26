using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SteamWorksInt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        try
        {
            Steamworks.SteamClient.Init(4135240);
            PrintYourName();
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }

    }

    private void PrintYourName()
    {
        Debug.Log(Steamworks.SteamClient.Name);
    }

}
