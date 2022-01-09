using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PizarronBotones : MonoBehaviour
{
    public GameObject firstSelected,video1exit,video2exit,video3exit;
    public GameObject pizzaronUI,video1,video2,video3,pizzaronSuperiorUI; 
    public void Close()
    {
        pizzaronUI.SetActive(false); 
        Time.timeScale = 1f;
    } 
    public void LightClose()
    {
        pizzaronSuperiorUI.SetActive(true);
        video1.SetActive(false);
        video2.SetActive(false);
        video3.SetActive(false);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstSelected);
    }
    public void Video1()
    {
        pizzaronSuperiorUI.SetActive(false);
        video1.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(video1exit);
        video2.SetActive(false);
        video3.SetActive(false);
    }
    public void Video2()
    {
        pizzaronSuperiorUI.SetActive(false);
        video2.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(video2exit);
        video1.SetActive(false); 
        video3.SetActive(false);
    }
    public void Video3()
    {
        pizzaronSuperiorUI.SetActive(false);
        video3.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(video3exit);
        video1.SetActive(false);
        video2.SetActive(false); 
    }
}
