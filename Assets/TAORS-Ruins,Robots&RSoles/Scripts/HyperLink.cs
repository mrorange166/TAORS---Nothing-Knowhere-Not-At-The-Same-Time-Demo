using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperLink : MonoBehaviour
{
    public void OpenURL(string link)
    {
        Application.OpenURL(link);

    }
    public void OpenYoutube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=iYgJ9WCHrRg");
    }
}
