using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerControls playerControls;

  public  Vector2 movementInput; //Public so it can be seen in the inspector when we go into the game
    

    private void OnEnable()
    {
        if(playerControls == null)
        {
            playerControls = new PlayerControls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }    

        playerControls.Enable();
    }

    private void OnDisable() 
    {
        playerControls.Disable();
    }
    
}
