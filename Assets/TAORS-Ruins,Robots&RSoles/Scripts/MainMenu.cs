using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //public FadeCamera fade;


    public void PlayGame()
    {
    
    //    fade.GetComponent<FadeCamera>().FadeOut(5f);
        SceneManager.LoadScene(17);
    }

    public void QuiteGame()
    {
        Application.Quit();
    }
}
