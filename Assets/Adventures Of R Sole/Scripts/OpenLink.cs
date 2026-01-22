using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenFacebookLink()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100091919088112");
    }

}
