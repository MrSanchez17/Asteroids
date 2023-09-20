using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class NewControls : MonoBehaviour
{
    private InputPlayerActions ipa;
    public Vector2 moveValue;
    public UnityEvent OnReloadPlayer;
    public UnityEvent OnShoot;

  private void Awake()
    {
        ipa = new InputPlayerActions();
        ipa.Player.Shoot.started += OnShootPlayer;
        ipa.Player.Action.canceled += OnStopMove;
        ipa.Player.Action.performed += OnAction;
        ipa.Player.Reload.performed += OnReload;
    }

    private void OnShootPlayer(InputAction.CallbackContext c)
    {
        OnShoot.Invoke();
    }

    private void OnStopMove(InputAction.CallbackContext c)
    {
        moveValue = Vector2.zero;
    }

    private void OnAction(InputAction.CallbackContext c)
    {

        moveValue = c.ReadValue<Vector2>();

    }

    private void OnEnable()
    {
        ipa.Enable();
    }

    private void OnDisable()
    {
        ipa.Disable();
    }

    private void OnReload(InputAction.CallbackContext c)
    {
        OnReloadPlayer.Invoke();
    }
}