using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bumper : MonoBehaviour
{
    private PlayerActions playerActions;
    private InputAction bumpAction;

    void Awake()
    {
        playerActions = new PlayerActions();
        bumpAction = playerActions.BumperControl.Bump;
    }

    void OnEnable()
    {
        bumpAction.Enable();
    }

    void OnDisable()
    {
        bumpAction.Disable();
    }
}
