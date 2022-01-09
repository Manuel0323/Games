using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class PlayerMovement : MonoBehaviour
{
    public GameObject interactIcon;
    public float moveSpeed = 5f;
    private Vector2 boxSize = new Vector2(0.1f, 1f);
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                CheckInteraction();
            }
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
            animator.SetFloat("horizontal", movement.x);
            animator.SetFloat("vertical", movement.y);
            animator.SetFloat("speed", movement.sqrMagnitude);
        }
        
    }
    private void FixedUpdate()
    {
        if (!PauseMenu.GameIsPaused)
        {
            rb.MovePosition(rb.position + movement*moveSpeed*Time.fixedDeltaTime);
        }
    }
    public void OpenIcon()
    {
        interactIcon.SetActive(true);
    }
    public void CloseIcon()
    {
        interactIcon.SetActive(false);
    }
    private void CheckInteraction()
    { 
        RaycastHit2D[] hits = Physics2D.BoxCastAll(transform.position, boxSize, 0, Vector2.zero);
        if (hits.Length > 0)
        {
            foreach (RaycastHit2D rc in hits)
            {
                if (rc.transform.GetComponent<Interactable>())
                {
                    rc.transform.GetComponent<Interactable>().Interact();
                    return;
                }
            }
        }
        
    }
}
