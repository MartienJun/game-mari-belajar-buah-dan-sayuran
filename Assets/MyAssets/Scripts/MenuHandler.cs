using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject DifficultyMenu;
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
    
    public void DifficultyClicked() 
    {
        DifficultyMenu.SetActive(true);
        AboutMenu.SetActive(false);
        ExitMenu.SetActive(false);
    }

    public void AboutClicked() 
    {
        DifficultyMenu.SetActive(false);
        AboutMenu.SetActive(true);
        ExitMenu.SetActive(false);
    }

    public void ExitClicked()
    {
        DifficultyMenu.SetActive(false);
        AboutMenu.SetActive(false);
        ExitMenu.SetActive(true);
    }

    public void BackClicked() 
    {
        DifficultyMenu.SetActive(false);
        AboutMenu.SetActive(false);
        ExitMenu.SetActive(false);
    }

    public void GithubClicked()
    {
        Application.OpenURL(UrlGithub);
    }
}