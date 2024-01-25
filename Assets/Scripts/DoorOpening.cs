using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] private Button _input;
    [SerializeField] private Animator _door;
    private void Awake()
    {
        _input.MoveKeyPressed += OnMoveKeyPressed;
    }

    private void OnMoveKeyPressed()
    {
        _door.SetTrigger("Open");
    }
}
