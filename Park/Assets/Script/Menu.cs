using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gotoLayout2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void howtoplay()
    {
        SceneManager.LoadScene("HowtoPlay");
    }

    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void about()
    {
        SceneManager.LoadScene("About");
    }

    public void exit()
    {
        Application.Quit();
        System.Diagnostics.Process.GetCurrentProcess().Kill();
    }
}
