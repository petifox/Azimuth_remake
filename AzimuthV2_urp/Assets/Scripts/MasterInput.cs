using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MasterInput : MonoBehaviour
{
    static MasterInput Instance;
    public static Vector2 MovementVector;
    [SerializeField] static bool Inverted;

    private void OnEnable()
    {
        DontDestroyOnLoad(this.gameObject);
        if (Instance == null)
            Instance = this;
    }
    private void OnDisable()
    {
        Instance = null;
    }

    public static void Invert(bool value)
    {
        if (Inverted != value)
        {
            MovementVector = MovementVector * -1;
        }

        Inverted = value;
    }

    public void OnMovement(InputAction.CallbackContext value)
    {
        if (Instance == this)
        {
            if(Inverted)
            {
                MovementVector = value.ReadValue<Vector2>() * -1;
            }
            else
            {
                MovementVector = value.ReadValue<Vector2>();
            }
        }
    }
}
