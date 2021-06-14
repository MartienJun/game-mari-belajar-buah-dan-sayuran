using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuHandler : MonoBehaviour
{
    public GameObject Menu;
    public GameObject Question;
    private bool flagActive = false;

    public void ChangeScreen(string scene_name) 
    { 
        SceneManager.LoadScene(scene_name); 
    } 
    
    public void MenuClicked() 
    {
        if(Question.activeSelf.Equals(true))
        {
            Menu.SetActive(true);
            Question.SetActive(false);
            flagActive = true;
        }
        else
        {
            Menu.SetActive(true);
        }
    }

    public void BackClicked() 
    {
        if(flagActive == true)
        {
            Menu.SetActive(false);
            Question.SetActive(true);
        }
        else
        {
            Menu.SetActive(false);
        }
    }
}