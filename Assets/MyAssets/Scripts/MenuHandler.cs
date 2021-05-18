using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject AboutMenu; 
    public GameObject ExitMenu;
    public string UrlGithub = "https://github.com/MartienJun";

    public void ExitApp() 
    { 
        Application.Quit();
    } 
    
    public void ChangeScreen(string scene_name) 
    { 
        SceneManager.LoadScene(scene_name); 
    } 
    
    public void AboutClicked() 
    {
        AboutMenu.SetActive(true);
        ExitMenu.SetActive(false);
    }

    public void ExitClicked()
    {
        AboutMenu.SetActive(false);
        ExitMenu.SetActive(true);
    }

    public void BackClicked() 
    {
        AboutMenu.SetActive(false);
        ExitMenu.SetActive(false);
    }

    public void GithubClicked()
    {
        Application.OpenURL(UrlGithub);
    }
}