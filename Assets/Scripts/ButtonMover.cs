using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMover : MonoBehaviour
{
    [SerializeField] private Button _input;
    [SerializeField] private GameObject _button;

    private void Awake()
    {
        _input.MoveKeyPressed += OnMoveKeyPressed;
    }

    private void OnMoveKeyPressed()
    {
        _button.transform.localPosition = new Vector3
        {
            x = 0,
            y = -0.5f,
            z = 0
        };
}
}
