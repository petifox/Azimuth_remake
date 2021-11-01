using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MasterInput : MonoBehaviour
{
    static MasterInput Instance;
    public static Vector2 MovementVector;

    private void OnEnable()
    {
        if (Instance == null)
            Instance = this;
    }
    private void OnDisable()
    {
        Instance = null;
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        if (Instance == this)
        {
            MovementVector = value.ReadValue<Vector2>();
        }
    }
}
