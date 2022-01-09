using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : Interactable
{
    public int Scene;

    public override void Interact()
    {
        SceneManager.LoadScene(Scene);
    }

}
