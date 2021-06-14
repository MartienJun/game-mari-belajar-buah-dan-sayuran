using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class BGMToggler : MonoBehaviour
{
    public Sprite toggleOnSprite;
    public Sprite toggleOffSprite;
    public AudioSource bgm;
    private bool isToggled = true;
    private Image image;
    
    void Start()
    {
        image = GetComponent<Image>();
        UpdateSprite();
    }

    public void setBgmButton()
    {
        isToggled =! isToggled;
        UpdateSprite();
    }

    void UpdateSprite()
    {
        if(isToggled)
        {
            image.sprite = toggleOnSprite;
            bgm.UnPause();
        }
        else
        {
            image.sprite = toggleOffSprite;
            bgm.Pause();
        }
    }
}