using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Pizarron : Interactable
{
    public GameObject pizarronUI,canvasUI;
    public GameObject firstSelected;
    public override void Interact()
    {
        canvasUI.SetActive(true);
        pizarronUI.SetActive(true);
        Time.timeScale = 0f;
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(firstSelected);
    }
}
