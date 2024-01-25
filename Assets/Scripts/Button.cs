using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public event UnityAction MoveKeyPressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveKeyPressed?.Invoke();

        }

    }
}
